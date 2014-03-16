// 기본 DLL 파일입니다.

#include "stdafx.h"

#include <cstdlib>
#include <cmath>

extern "C" void init(unsigned char *, int, int, int, unsigned int *, int, int, char *);
extern "C" void render();
extern "C" void setParams(float, float, float, float, bool);
extern "C" void setViewMatrix(float *);
extern "C" void freeCudaBuffers();

#pragma managed

#include "volrender.h"

namespace volrender {

	Render::Render(int volume_width, int volume_height, int volume_depth, int img_width, int img_height)
	{
		_volume_width = volume_width;
		_volume_height = volume_height;
		_volume_depth = volume_depth;
		_volume_size = volume_width*volume_height*volume_depth;
		_img_width = img_width;
		_img_height = img_height;
		_img_size = img_width*img_height;
		_host_volume = (unsigned char *)malloc(_volume_size*sizeof(unsigned char));
		_host_image = (unsigned int *)malloc(_img_size*sizeof(unsigned int)); // RGBA

		char *error_str = (char *)malloc(256*sizeof(char));
		init(_host_volume, volume_width, volume_height, volume_depth, _host_image, img_width, img_height, error_str);
	}

	void Render::Update(array<Byte>^% in_volume, array<int>^% out_image)
	{
		for(int i=0; i < _volume_size; i++)
		{
			_host_volume[i] = in_volume[i];
		}

		render();

		for(int i=0; i < _img_size; i++)
		{
			out_image[i] = (_host_image[i]>>8) | (255<<24); // RGBA to ARGB
		}
	}

	void Render::SetParams(float density, float brightness, float transferOffset, float transferScale, bool linearFiltering)
	{
		setParams(density, brightness, transferOffset, transferScale, linearFiltering);
	}

	void Render::SetViewMatrix(float rotation_x, float rotation_y, float rotation_z, float translation_x, float translation_y, float translation_z)
	{
		// http://www.songho.ca/opengl/gl_anglestoaxes.html
		float modelView[16];
		const float DEG2RAD = 3.141593f / 180.0f;
		float theta, sx, cx, sy, cy, sz, cz;

		theta = rotation_x * DEG2RAD;
		sx = sinf(theta);
		cx = cosf(theta);

		theta = rotation_y * DEG2RAD;
		sy = sinf(theta);
		cy = cosf(theta);

		theta = rotation_z * DEG2RAD;
		sz = sinf(theta);
		cz = cosf(theta);

		// left axis
		modelView[0] = cy*cz;
		modelView[1] = sx*sy*cz + cx*sz;
		modelView[2] = -cx*sy*cz + sx*sz;
		modelView[3] = 0;

		// up axis
		modelView[4] = -cy*sz;
		modelView[5] = -sx*sy*sz + cx*cz;
		modelView[6] = cx*sy*sz + sx*cz;
		modelView[7] = 0;

		// forward axis
		modelView[8] = sy;
		modelView[9] = -sx*cy;
		modelView[10] = cx*cy;
		modelView[11] = 0;

		// translation
		modelView[12] = translation_x;
		modelView[13] = translation_y;
		modelView[14] = translation_z;
		modelView[15] = 1;

		setViewMatrix(modelView);
	}

	void Render::FreeBuffers()
	{
		free(_host_volume);
		free(_host_image);
		freeCudaBuffers();
	}

	Render::!Render()
	{
		FreeBuffers();
	}

}