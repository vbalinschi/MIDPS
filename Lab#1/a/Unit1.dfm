object Form1: TForm1
  Left = 301
  Top = 247
  Width = 870
  Height = 640
  Caption = 'Form1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 368
    Top = 144
    Width = 32
    Height = 13
    Caption = 'Label1'
  end
  object Button1: TButton
    Left = 136
    Top = 168
    Width = 75
    Height = 25
    Caption = 'UP'
    TabOrder = 0
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 136
    Top = 256
    Width = 75
    Height = 25
    Caption = 'DOWN'
    TabOrder = 1
    OnClick = Button2Click
  end
  object incr: TEdit
    Left = 256
    Top = 216
    Width = 121
    Height = 21
    TabOrder = 2
  end
  object Exit: TButton
    Left = 136
    Top = 320
    Width = 73
    Height = 25
    Caption = 'Exit'
    TabOrder = 3
    OnClick = ExitClick
  end
end
