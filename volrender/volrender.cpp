// 기본 DLL 파일입니다.

#include "stdafx.h"

#include "volrender.h"

// TODO:

int iDivUp(int a, int b)
{
    return (a % b != 0) ? (a / b + 1) : (a / b);
}


extern "C" void updateVolume();
extern "C" void freeCudaBuffers();

/*
extern "C" void setTextureFilterMode(bool bLinearFilter);
extern "C" void initCuda(void *h_volume, cudaExtent volumeSize);
extern "C" void render_kernel(dim3 gridSize, dim3 blockSize, uint *d_output, uint imageW, uint imageH,
                              float density, float brightness, float transferOffset, float transferScale);
extern "C" void copyInvViewMatrix(float *invViewMatrix, size_t sizeofMatrix);
*/

/*
typedef unsigned int uint;
const int VOL_WIDTH = 640;
const int VOL_HEIGHT = 480;
const int VOL_DEPTH = 300;


	// Parameters
	m_density = 0.5f;
	m_brightness = 5.0f;
	m_transferOffset = 0.02f;
	m_transferScale = 1.0f;
	m_linearFiltering = true;
	m_viewRotation = make_float3(-70.0, 0.0, 0.0);
	m_viewTranslation = make_float3(0.0, 0.0, -5.0f);

*/

// 스타트 버튼을 누르고나서

// Init CUDA
// Alloc volume

// initCuda(m_h_volume, make_cudaExtent(VOL_WIDTH, VOL_HEIGHT, VOL_DEPTH));
// unsigned char *h_output = (unsigned char *)malloc(width*height*4);

// Set gridsize and blocksize
//	m_width = (uint)cx;
//	m_height = (uint)cy;
//	m_blockSize = dim3(16,16);
//	m_gridSize = dim3(iDivUp(m_width, m_blockSize.x), iDivUp(m_height, m_blockSize.y));

//	m_h_volume = calloc(VOL_WIDTH*VOL_HEIGHT*VOL_DEPTH, sizeof(unsigned char));

// strobo 실행중

// Set ViewMatrix
/*
	GLfloat modelView[16];
	glMatrixMode(GL_MODELVIEW);
	glPushMatrix();
	glLoadIdentity();
	glRotatef(-m_viewRotation.x, 1.0, 0.0, 0.0);
	glRotatef(-m_viewRotation.y, 0.0, 1.0, 0.0);
	glTranslatef(-m_viewTranslation.x, -m_viewTranslation.y, -m_viewTranslation.z);
	glGetFloatv(GL_MODELVIEW_MATRIX, modelView);
	glPopMatrix();

	m_invViewMatrix[0] = modelView[0];
	m_invViewMatrix[1] = modelView[4];
	m_invViewMatrix[2] = modelView[8];
	m_invViewMatrix[3] = modelView[12];
	m_invViewMatrix[4] = modelView[1];
	m_invViewMatrix[5] = modelView[5];
	m_invViewMatrix[6] = modelView[9];
	m_invViewMatrix[7] = modelView[13];
	m_invViewMatrix[8] = modelView[2];
	m_invViewMatrix[9] = modelView[6];
	m_invViewMatrix[10] = modelView[10];
	m_invViewMatrix[11] = modelView[14];

	copyInvViewMatrix(m_invViewMatrix, sizeof(float4)*3);
*/

// Rendering

/*
	// clear image
	checkCudaErrors(cudaMemset(d_output, 0, m_width*m_height*4));

	// Reset volume
	memset((void *)m_h_volume, 0, VOL_WIDTH*VOL_HEIGHT*VOL_DEPTH);

	// Copy volume
	something something

	render_kernel(m_gridSize, m_blockSize, d_output, m_width, m_height, m_density, m_brightness, m_transferOffset, m_transferScale);

	checkCudaErrors(cudaMemcpy(h_output, d_output, width*height*4, cudaMemcpyDeviceToHost));

	getLastCudaError("kernel failed");
*/