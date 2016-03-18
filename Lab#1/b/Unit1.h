//---------------------------------------------------------------------------

#ifndef Unit1H
#define Unit1H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ExtCtrls.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
        TTimer *Timer1;
        TTimer *Timer2;
        TButton *Start;
        TButton *Stop;
        TButton *Zero;
        TEdit *Edit1;
        TEdit *Edit2;
        TButton *Exit;
        TLabel *Label1;
        TLabel *Label2;
        void __fastcall ExitClick(TObject *Sender);
        void __fastcall Timer2Timer(TObject *Sender);
        void __fastcall Timer1Timer(TObject *Sender);
        void __fastcall StartClick(TObject *Sender);
        void __fastcall StopClick(TObject *Sender);
        void __fastcall ZeroClick(TObject *Sender);
private:	// User declarations
public:		// User declarations
        __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
