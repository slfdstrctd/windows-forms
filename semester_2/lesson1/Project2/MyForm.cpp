#include "MyForm.h"
#include "gsl/gsl_sf_bessel.h"
//#include	<iostream>

using namespace System;
using namespace System::Windows::Forms;

[STAThreadAttribute]
void main(array<String^>^ args) {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	Project2::MyForm form;
	Application::Run(% form);

	//double x = 5.0;
	//double expected = -0.17759677131433830434739701;
	//double y = gsl_sf_dawson(x);
	//std::cout << "J0(5.0) = %.18f" << y;
	//std::cout << "exact   = %.18f\n" << expected;
}



