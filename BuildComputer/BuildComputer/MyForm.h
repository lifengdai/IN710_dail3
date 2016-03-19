#pragma once
#include "Maker.h"
namespace BuildComputer {

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
	private: Maker* maker;
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
			maker = new Maker();
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
	private: System::Windows::Forms::Button^  btnPrint;
	private: System::Windows::Forms::GroupBox^  gpbxType;
	private: System::Windows::Forms::RadioButton^  rdobtnMultimedia;
	protected:
	private: System::Windows::Forms::RadioButton^  rdobtnBusiness;
	private: System::Windows::Forms::RadioButton^  rdobtngame;
	private: System::Windows::Forms::ListBox^  lstbxShow;


	protected:

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
			this->btnPrint = (gcnew System::Windows::Forms::Button());
			this->gpbxType = (gcnew System::Windows::Forms::GroupBox());
			this->rdobtnMultimedia = (gcnew System::Windows::Forms::RadioButton());
			this->rdobtnBusiness = (gcnew System::Windows::Forms::RadioButton());
			this->rdobtngame = (gcnew System::Windows::Forms::RadioButton());
			this->lstbxShow = (gcnew System::Windows::Forms::ListBox());
			this->gpbxType->SuspendLayout();
			this->SuspendLayout();
			// 
			// btnPrint
			// 
			this->btnPrint->Location = System::Drawing::Point(31, 26);
			this->btnPrint->Name = L"btnPrint";
			this->btnPrint->Size = System::Drawing::Size(162, 39);
			this->btnPrint->TabIndex = 0;
			this->btnPrint->Text = L" Print Spec";
			this->btnPrint->UseVisualStyleBackColor = true;
			this->btnPrint->Click += gcnew System::EventHandler(this, &MyForm::btnPrint_Click);
			// 
			// gpbxType
			// 
			this->gpbxType->Controls->Add(this->rdobtnMultimedia);
			this->gpbxType->Controls->Add(this->rdobtnBusiness);
			this->gpbxType->Controls->Add(this->rdobtngame);
			this->gpbxType->Location = System::Drawing::Point(31, 105);
			this->gpbxType->Name = L"gpbxType";
			this->gpbxType->Size = System::Drawing::Size(162, 110);
			this->gpbxType->TabIndex = 1;
			this->gpbxType->TabStop = false;
			this->gpbxType->Text = L"Machine Type";
			// 
			// rdobtnMultimedia
			// 
			this->rdobtnMultimedia->AutoSize = true;
			this->rdobtnMultimedia->Location = System::Drawing::Point(6, 83);
			this->rdobtnMultimedia->Name = L"rdobtnMultimedia";
			this->rdobtnMultimedia->Size = System::Drawing::Size(123, 22);
			this->rdobtnMultimedia->TabIndex = 2;
			this->rdobtnMultimedia->TabStop = true;
			this->rdobtnMultimedia->Text = L"Multimedia";
			this->rdobtnMultimedia->UseVisualStyleBackColor = true;
			// 
			// rdobtnBusiness
			// 
			this->rdobtnBusiness->AutoSize = true;
			this->rdobtnBusiness->Location = System::Drawing::Point(6, 55);
			this->rdobtnBusiness->Name = L"rdobtnBusiness";
			this->rdobtnBusiness->Size = System::Drawing::Size(105, 22);
			this->rdobtnBusiness->TabIndex = 2;
			this->rdobtnBusiness->TabStop = true;
			this->rdobtnBusiness->Text = L"Business";
			this->rdobtnBusiness->UseVisualStyleBackColor = true;
			// 
			// rdobtngame
			// 
			this->rdobtngame->AutoSize = true;
			this->rdobtngame->Location = System::Drawing::Point(6, 27);
			this->rdobtngame->Name = L"rdobtngame";
			this->rdobtngame->Size = System::Drawing::Size(69, 22);
			this->rdobtngame->TabIndex = 2;
			this->rdobtngame->TabStop = true;
			this->rdobtngame->Text = L"Game";
			this->rdobtngame->UseVisualStyleBackColor = true;
			// 
			// lstbxShow
			// 
			this->lstbxShow->FormattingEnabled = true;
			this->lstbxShow->ItemHeight = 18;
			this->lstbxShow->Location = System::Drawing::Point(199, 26);
			this->lstbxShow->Name = L"lstbxShow";
			this->lstbxShow->Size = System::Drawing::Size(494, 184);
			this->lstbxShow->TabIndex = 2;
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(9, 18);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(711, 235);
			this->Controls->Add(this->lstbxShow);
			this->Controls->Add(this->gpbxType);
			this->Controls->Add(this->btnPrint);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->gpbxType->ResumeLayout(false);
			this->gpbxType->PerformLayout();
			this->ResumeLayout(false);

		}
#pragma endregion
			private: System::Void btnPrint_Click(System::Object^  sender, System::EventArgs^  e) {
				lstbxShow->Items->Clear();
				if (rdobtngame->Checked)
				{
					maker->GameComputerAssemblyLine()->printToDisplay(lstbxShow);
				}
				if (rdobtnBusiness->Checked)
				{
					maker->BusinessComputerAssemblyLine()->printToDisplay(lstbxShow);
				}
				if (rdobtnMultimedia->Checked)
				{
					maker->MultimediaComputerAssemblyLine()->printToDisplay(lstbxShow);
				}
			}
};
}
