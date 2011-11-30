// StarcraftReader.h : main header file for the StarcraftReader DLL
//

#pragma once

#ifndef __AFXWIN_H__
	#error "include 'stdafx.h' before including this file for PCH"
#endif

#include "resource.h"		// main symbols


// CStarcraftReaderApp
// See StarcraftReader.cpp for the implementation of this class
//

class CStarcraftReaderApp : public CWinApp
{
public:
	CStarcraftReaderApp();

// Overrides
public:
	virtual BOOL InitInstance();

	DECLARE_MESSAGE_MAP()
};
