#include "pch.h"

void __stdcall UpdateCameraSetting(Camera camera)
{
	Camera currentCamera = camera;
}

void __stdcall GetCameraImage(CameraImageData* cameraImageData)
{
	cameraImageData->CameraId = 3;

	strcpy_s(cameraImageData->CameraName, "camera3");

	cameraImageData->Image[0] = 3;
	cameraImageData->Image[1] = 3;
	cameraImageData->Image[2] = 3;
}

void __stdcall GetCameraImage2(BYTE* image)
{
	image[0] = 1;
	image[1] = 2;
	image[2] = 3;
}
