// stdafx.h : include file for standard system include files,
// or project specific include files that are used frequently, but
// are changed infrequently

#pragma once

#ifndef VC_EXTRALEAN
#define VC_EXTRALEAN            // Exclude rarely-used stuff from Windows headers
#endif

#include "targetver.h"

#define _ATL_CSTRING_EXPLICIT_CONSTRUCTORS      // some CString constructors will be explicit

#include <afxwin.h>         // MFC core and standard components
#include <afxext.h>         // MFC extensions

#ifndef _AFX_NO_OLE_SUPPORT
#include <afxole.h>         // MFC OLE classes
#include <afxodlgs.h>       // MFC OLE dialog classes
#include <afxdisp.h>        // MFC Automation classes
#endif // _AFX_NO_OLE_SUPPORT

#ifndef _AFX_NO_DB_SUPPORT
#include <afxdb.h>                      // MFC ODBC database classes
#endif // _AFX_NO_DB_SUPPORT

#ifndef _AFX_NO_DAO_SUPPORT
#include <afxdao.h>                     // MFC DAO database classes
#endif // _AFX_NO_DAO_SUPPORT

#ifndef _AFX_NO_OLE_SUPPORT
#include <afxdtctl.h>           // MFC support for Internet Explorer 4 Common Controls
#endif
#ifndef _AFX_NO_AFXCMN_SUPPORT
#include <afxcmn.h>                     // MFC support for Windows Common Controls
#endif // _AFX_NO_AFXCMN_SUPPORT

// Putting the things I will need to call windows functions
#include "Starcraft2Structures.h"
#include <stdio.h>
#include <Windows.h>
#include <WinBase.h>
#include <tlhelp32.h>
#include <tchar.h>
#include <hash_map>

// Defining the export items
#ifdef STARCRAFTREADER_API
#undef STARCRAFTREADER_API
#endif


#ifdef STARCRAFTREADER_EXPORTS
#define STARCRAFTREADER_API   __declspec(dllexport)
#else
#define STARCRAFTREADER_API   __declspec(dllimport)
#endif 

// #define STARCRAFTREADER_API_EXPORT __declspec(dllexport)
// #define STARCRAFTREADER_API_IMPORT __declspec(dllexport)