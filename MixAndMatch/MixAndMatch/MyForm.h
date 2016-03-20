#pragma once
#include <msclr\marshal_cppstd.h>
#include "MakeMonstor.h"

namespace MixAndMatch {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace msclr::interop;

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
	private: System::Windows::Forms::Label^  lblHead;
	protected:
	private: System::Windows::Forms::Label^  lblBody;
	private: System::Windows::Forms::Label^  lblLegs;
	private: System::Windows::Forms::ComboBox^  cmbxHead;
	private: System::Windows::Forms::ComboBox^  cmbxBody;
	private: System::Windows::Forms::ComboBox^  cmbxLegs;
	private:
		MakeMonstor* makemonstor;

	private: System::Windows::Forms::Button^  btnMake;
	private: System::Windows::Forms::PictureBox^  picbxHead;
	private: System::Windows::Forms::PictureBox^  picbxBody;
	private: System::Windows::Forms::PictureBox^  picbxLegs;




	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->lblHead = (gcnew System::Windows::Forms::Label());
			this->lblBody = (gcnew System::Windows::Forms::Label());
			this->lblLegs = (gcnew System::Windows::Forms::Label());
			this->cmbxHead = (gcnew System::Windows::Forms::ComboBox());
			this->cmbxBody = (gcnew System::Windows::Forms::ComboBox());
			this->cmbxLegs = (gcnew System::Windows::Forms::ComboBox());
			this->btnMake = (gcnew System::Windows::Forms::Button());
			this->picbxHead = (gcnew System::Windows::Forms::PictureBox());
			this->picbxBody = (gcnew System::Windows::Forms::PictureBox());
			this->picbxLegs = (gcnew System::Windows::Forms::PictureBox());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->picbxHead))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->picbxBody))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->picbxLegs))->BeginInit();
			this->SuspendLayout();
			makemonstor = new MakeMonstor(cmbxHead, cmbxBody, cmbxLegs);
			// 
			// lblHead
			// 
			this->lblHead->AutoSize = true;
			this->lblHead->Font = (gcnew System::Drawing::Font(L"SimSun", 16, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(134)));
			this->lblHead->Location = System::Drawing::Point(516, 36);
			this->lblHead->Name = L"lblHead";
			this->lblHead->Size = System::Drawing::Size(79, 33);
			this->lblHead->TabIndex = 0;
			this->lblHead->Text = L"Head";
			// 
			// lblBody
			// 
			this->lblBody->AutoSize = true;
			this->lblBody->Font = (gcnew System::Drawing::Font(L"SimSun", 16, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(134)));
			this->lblBody->Location = System::Drawing::Point(516, 174);
			this->lblBody->Name = L"lblBody";
			this->lblBody->Size = System::Drawing::Size(79, 33);
			this->lblBody->TabIndex = 1;
			this->lblBody->Text = L"Body";
			// 
			// lblLegs
			// 
			this->lblLegs->AutoSize = true;
			this->lblLegs->Font = (gcnew System::Drawing::Font(L"SimSun", 16, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(134)));
			this->lblLegs->Location = System::Drawing::Point(516, 342);
			this->lblLegs->Name = L"lblLegs";
			this->lblLegs->Size = System::Drawing::Size(79, 33);
			this->lblLegs->TabIndex = 2;
			this->lblLegs->Text = L"Legs";
			// 
			// cmbxHead
			// 
			this->cmbxHead->FormattingEnabled = true;
			this->cmbxHead->Location = System::Drawing::Point(601, 43);
			this->cmbxHead->Name = L"cmbxHead";
			this->cmbxHead->Size = System::Drawing::Size(307, 26);
			this->cmbxHead->TabIndex = 3;
			// 
			// cmbxBody
			// 
			this->cmbxBody->FormattingEnabled = true;
			this->cmbxBody->Location = System::Drawing::Point(601, 181);
			this->cmbxBody->Name = L"cmbxBody";
			this->cmbxBody->Size = System::Drawing::Size(307, 26);
			this->cmbxBody->TabIndex = 4;
			// 
			// cmbxLegs
			// 
			this->cmbxLegs->FormattingEnabled = true;
			this->cmbxLegs->Location = System::Drawing::Point(601, 349);
			this->cmbxLegs->Name = L"cmbxLegs";
			this->cmbxLegs->Size = System::Drawing::Size(307, 26);
			this->cmbxLegs->TabIndex = 5;
			// 
			// btnMake
			// 
			this->btnMake->Location = System::Drawing::Point(641, 470);
			this->btnMake->Name = L"btnMake";
			this->btnMake->Size = System::Drawing::Size(195, 62);
			this->btnMake->TabIndex = 6;
			this->btnMake->Text = L"Make Monster";
			this->btnMake->UseVisualStyleBackColor = true;
			this->btnMake->Click += gcnew System::EventHandler(this, &MyForm::btnMake_Click);
			// 
			// picbxHead
			// 
			this->picbxHead->Location = System::Drawing::Point(12, 3);
			this->picbxHead->Name = L"picbxHead";
			this->picbxHead->Size = System::Drawing::Size(368, 339);
			this->picbxHead->TabIndex = 7;
			this->picbxHead->TabStop = false;
			// 
			// picbxBody
			// 
			this->picbxBody->Location = System::Drawing::Point(12, 349);
			this->picbxBody->Name = L"picbxBody";
			this->picbxBody->Size = System::Drawing::Size(368, 340);
			this->picbxBody->TabIndex = 8;
			this->picbxBody->TabStop = false;
			// 
			// picbxLegs
			// 
			this->picbxLegs->Location = System::Drawing::Point(12, 695);
			this->picbxLegs->Name = L"picbxLegs";
			this->picbxLegs->Size = System::Drawing::Size(368, 340);
			this->picbxLegs->TabIndex = 9;
			this->picbxLegs->TabStop = false;
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(9, 18);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(973, 1048);
			this->Controls->Add(this->picbxLegs);
			this->Controls->Add(this->picbxBody);
			this->Controls->Add(this->picbxHead);
			this->Controls->Add(this->btnMake);
			this->Controls->Add(this->cmbxLegs);
			this->Controls->Add(this->cmbxBody);
			this->Controls->Add(this->cmbxHead);
			this->Controls->Add(this->lblLegs);
			this->Controls->Add(this->lblBody);
			this->Controls->Add(this->lblHead);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->picbxHead))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->picbxBody))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->picbxLegs))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
private: System::Void btnMake_Click(System::Object^  sender, System::EventArgs^  e) {
	picbxHead->Image = makemonstor->monstor(marshal_as<string>(cmbxHead->SelectedItem->ToString()),
		marshal_as<string>(cmbxBody->SelectedItem->ToString()),
		marshal_as<string>(cmbxLegs->SelectedItem->ToString())
		)->getHead();
	picbxBody->Image = makemonstor->monstor(marshal_as<string>(cmbxHead->SelectedItem->ToString()),
		marshal_as<string>(cmbxBody->SelectedItem->ToString()),
		marshal_as<string>(cmbxLegs->SelectedItem->ToString())
		)->getBody();
	picbxLegs->Image = makemonstor->monstor(marshal_as<string>(cmbxHead->SelectedItem->ToString()),
		marshal_as<string>(cmbxBody->SelectedItem->ToString()),
		marshal_as<string>(cmbxLegs->SelectedItem->ToString())
		)->getLegs();
}
};
}
