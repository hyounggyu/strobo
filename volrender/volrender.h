// volrender.h

#pragma once

using namespace System;

namespace volrender {

	public ref class Render
	{
	public:
		Render(int volume_width, int volume_height, int volume_depth, int img_width, int img_height);
		void Update(array<Byte>^ in_volume, array<Byte>^ out_image);
		void SetParams(float density, float brightness, float transperOffset, float transperScale, bool linearFiltering);
		void SetViewMatrix(float rotation_x, float rotation_y, float translation_x, float translation_y, float translation_z);
		~Render() { this->!Render(); }
		!Render();
	private:
		int _volume_width, _volume_height, _volume_depth, _volume_size;
		int _img_width, _img_height, _img_size;
		unsigned char* _host_volume;
		unsigned int* _host_image;
		void Render::FreeBuffers();
	};
}
