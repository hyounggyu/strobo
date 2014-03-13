// 기본 DLL 파일입니다.

#include "stdafx.h"

#include <stdlib.h>

extern "C" void init(unsigned char *, int, int, int, unsigned int *, int, int);
extern "C" void render();
extern "C" void setParams(float, float, float, float, bool);
extern "C" void setViewMatrix(float, float, float, float, float);
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

		init(_host_volume, volume_width, volume_height, volume_depth, _host_image, img_width, img_height);
	}

	void Render::Update(array<Byte>^ in_volume, array<Byte>^ out_image)
	{
		for(int i=0; i < _volume_size; i++)
		{
			_host_volume[i] = in_volume[i];
		}

		render();

		for(int i=0; i < _img_size*4; i++)
		{
			out_image[i] = _host_image[i]; // RGBA
		}
	}

	void Render::SetParams(float density, float brightness, float transperOffset, float transperScale, bool linearFiltering)
	{
		setParams(density, brightness, transperOffset, transperScale, linearFiltering);
	}

	void Render::SetViewMatrix(float rotation_x, float rotation_y, float translation_x, float translation_y, float translation_z)
	{
		setViewMatrix(rotation_x, rotation_y, translation_x, translation_y, translation_z);
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