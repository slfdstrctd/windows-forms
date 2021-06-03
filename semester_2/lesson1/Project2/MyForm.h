#pragma once
#include "gsl/gsl_sf_dawson.h"
#include "gsl/gsl_sf_bessel.h"
#include <msclr\marshal_cppstd.h>
#include <string>

namespace Project2 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ button1;
	private: System::Windows::Forms::Button^ button2;
	private: System::Windows::Forms::Button^ button3;
	private: System::Windows::Forms::Button^ button4;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::TextBox^ textBox1;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::PictureBox^ pictureBox1;
	protected:

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container^ components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->button3 = (gcnew System::Windows::Forms::Button());
			this->button4 = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->BeginInit();
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(12, 270);
			this->button1->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(88, 35);
			this->button1->TabIndex = 0;
			this->button1->Text = L"Принять";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(113, 270);
			this->button2->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(155, 35);
			this->button2->TabIndex = 1;
			this->button2->Text = L"Новое значение";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &MyForm::button2_Click);
			// 
			// button3
			// 
			this->button3->Location = System::Drawing::Point(283, 269);
			this->button3->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(156, 36);
			this->button3->TabIndex = 2;
			this->button3->Text = L"Построить график";
			this->button3->UseVisualStyleBackColor = true;
			this->button3->Click += gcnew System::EventHandler(this, &MyForm::button3_Click);
			// 
			// button4
			// 
			this->button4->Location = System::Drawing::Point(576, 270);
			this->button4->Name = L"button4";
			this->button4->Size = System::Drawing::Size(144, 36);
			this->button4->TabIndex = 3;
			this->button4->Text = L"Завершить работу";
			this->button4->UseVisualStyleBackColor = true;
			this->button4->Click += gcnew System::EventHandler(this, &MyForm::button4_Click);
			// 
			// label1
			// 
			this->label1->Location = System::Drawing::Point(18, 43);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(328, 25);
			this->label1->TabIndex = 4;
			this->label1->Text = L"Введите x:";
			this->label1->TextAlign = System::Drawing::ContentAlignment::MiddleRight;
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(110, 96);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(22, 17);
			this->label2->TabIndex = 5;
			this->label2->Text = L"x=";
			this->label2->Visible = false;
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(352, 46);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(200, 22);
			this->textBox1->TabIndex = 6;
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(110, 126);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(82, 17);
			this->label3->TabIndex = 7;
			this->label3->Text = L"Dawson(x)=";
			this->label3->Visible = false;
			// 
			// pictureBox1
			// 
			this->pictureBox1->BackColor = System::Drawing::Color::White;
			this->pictureBox1->BorderStyle = System::Windows::Forms::BorderStyle::Fixed3D;
			this->pictureBox1->Location = System::Drawing::Point(69, 12);
			this->pictureBox1->Name = L"pictureBox1";
			this->pictureBox1->Size = System::Drawing::Size(607, 252);
			this->pictureBox1->SizeMode = System::Windows::Forms::PictureBoxSizeMode::CenterImage;
			this->pictureBox1->TabIndex = 8;
			this->pictureBox1->TabStop = false;
			this->pictureBox1->Visible = false;
			// 
			// MyForm
			// 
			this->AcceptButton = this->button1;
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(732, 333);
			this->Controls->Add(this->pictureBox1);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->button4);
			this->Controls->Add(this->button3);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->button1);
			this->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->MinimumSize = System::Drawing::Size(750, 380);
			this->Name = L"MyForm";
			this->Text = L"Значение функции Доусона";
			this->Load += gcnew System::EventHandler(this, &MyForm::MyForm_Load);
			this->HelpRequested += gcnew System::Windows::Forms::HelpEventHandler(this, &MyForm::MyForm_HelpRequested);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion 
	private: System::Void MyForm_Load(System::Object^ sender, System::EventArgs^ e) {
	}

		   int type = 0;  // 0 - value, 1 - left, 2 - right

		   //accept
	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
		double left, right;
		if (!type) {
			double x;
			if (x.TryParse(textBox1->Text, x)) {
				label1->Hide();
				textBox1->Hide();

				double y = gsl_sf_dawson(x);
				label2->Text = "x=" + x;
				label3->Text = "Dawson(x)=" + y;
				label2->Show();
				label3->Show();
			}
			else {
				MessageBox::Show("Неверный формат числа.\nДля вызова справки нажмите F1", "Ошибка", MessageBoxButtons::OK, MessageBoxIcon::Error);
			}
		}
		else if (type == 1){
			type = 2;
			if (left.TryParse(textBox1->Text, left)) {
				label1->Text = "Введите правую границу интервала: ";
				textBox1->Text = "";
			}
			else {
				MessageBox::Show("Неверный формат числа.\nДля вызова справки нажмите F1", "Ошибка", MessageBoxButtons::OK, MessageBoxIcon::Error);
			}
		}
		else if (type == 2) {
			pictureBox1->Show();
			if (right.TryParse(textBox1->Text, right)) { //&& right >= left
				label1->Hide();
				textBox1->Text = "";
				textBox1->Hide();

				// add plot
					pictureBox1->Refresh();
			
					Color^ col = gcnew Color();
					Pen^ myPen = gcnew Pen(col->Blue);

					Graphics ^g = pictureBox1->CreateGraphics();
					g->Clear(col->White);

					int nmbInterv = 100;
					float xmin = left, xmax = right, ymin = gsl_sf_dawson(xmin), ymax = gsl_sf_dawson(xmax);
					//float xmin = left, xmax = right, ymin = gsl_sf_bessel_J0(xmin), ymax = gsl_sf_bessel_J0(xmax);

					float xstep = (xmax - xmin) / nmbInterv;
					float kx = pictureBox1->Width / xmax, ky = pictureBox1->Height / ymax;
					float x1 = xmin, y1 = gsl_sf_dawson(x1), x2, y2;
					//float x1 = xmin, y1 = gsl_sf_bessel_J0(x1), x2, y2;
					
					x2 = x1;
					
					/*for (int i = 0; i < nmbInterv; i++)
					{
						x2 = x1 + xstep;
						y2 = gsl_sf_dawson(x2);
						g->DrawLine(myPen, kx * x1, pictureBox1->Height - ky * y1, kx* x2, pictureBox1->Height - ky * y2);
						x1 = x2;
						y1 = y2;
					}*/
					
					while (x2 <xmax ) {
						x2 = x1 + xstep;
						y2 = gsl_sf_dawson(x2);
						//if (y2 < 0) y2 *= -1;
						g->DrawLine(myPen, 100*x1, 100*y1+50, 100*x2, 100*y2+50);
						x1 = x2; //pictureBox1->Height/2
						y1 = y2;
					}
					//pictureBox1->Show();
						
				// input right and show plot
			}
			else {	
				MessageBox::Show("Неверный формат числа или правая граница меньше левой.\nДля вызова справки нажмите F1", "Ошибка", MessageBoxButtons::OK, MessageBoxIcon::Error);
			}
		}
	}

	// new
	private: System::Void button2_Click(System::Object^ sender, System::EventArgs^ e) {
		type = 0;
		textBox1->Text = "";
		label1->Text = "Введите x:";
		label2->Text = "x=";
		label3->Text = "Dawson(x)=";
		label2->Hide();
		label3->Hide();
		label1->Show();
		textBox1->Show();
		pictureBox1->Hide();
	}
	//plot
	private: System::Void button3_Click(System::Object^ sender, System::EventArgs^ e) {
		type = 1;
		label1->Text = "Введите левую границу интервала:";
		label1->Show();
		textBox1->Show();
		label2->Hide();
		label3->Hide();
		pictureBox1->Hide();
	}
	// exit 
	private: System::Void button4_Click(System::Object^ sender, System::EventArgs^ e) {
		Application::Exit();
	}

	private: System::Void MyForm_HelpRequested(System::Object^ sender, System::Windows::Forms::HelpEventArgs^ hlpevent) {
		MessageBox::Show("Числа вводятся в формате десятичных дробей. \nЦелая часть от дробной - отделяется запятой. \nНапример: x=-17,3", "Справка по программе", MessageBoxButtons::OK, MessageBoxIcon::Asterisk);
	}
};
}
