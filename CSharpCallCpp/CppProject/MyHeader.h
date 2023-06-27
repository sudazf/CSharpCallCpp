#pragma once

//相机设置
typedef struct CameraSetting
{
	int Setting1;
	bool Setting2;
	char Setting3[20];
};

//相机
typedef struct Camera
{
	int CameraId;
	bool IsActive;
	char CameraName[20];
	CameraSetting Setting;
};

//相机图片
typedef struct CameraImageData
{
public:
	int CameraId;
	char CameraName[20];
	BYTE Image[50000];
	CameraSetting Setting;
};


//写入相机设置
extern "C" _declspec(dllexport)  void __stdcall UpdateCameraSetting(Camera camera);

//读取相机传回的图片
extern "C" _declspec(dllexport)  void __stdcall GetCameraImage(CameraImageData* image);

//读取相机传回的图片2
extern "C" _declspec(dllexport)  void __stdcall GetCameraImage2(BYTE* image);


