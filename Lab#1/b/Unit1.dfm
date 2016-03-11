object Form1: TForm1
  Left = 424
  Top = 198
  Width = 390
  Height = 167
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
    Left = 104
    Top = 8
    Width = 161
    Height = 17
    Caption = 'Label1'
  end
  object Label2: TLabel
    Left = 104
    Top = 64
    Width = 161
    Height = 17
    Caption = 'Label2'
  end
  object Start: TButton
    Left = 16
    Top = 32
    Width = 65
    Height = 25
    Caption = 'Start'
    TabOrder = 0
    OnClick = StartClick
  end
  object Stop: TButton
    Left = 16
    Top = 80
    Width = 65
    Height = 25
    Caption = 'Stop'
    TabOrder = 1
    OnClick = StopClick
  end
  object Zero: TButton
    Left = 288
    Top = 32
    Width = 65
    Height = 25
    Caption = 'Zero'
    TabOrder = 2
    OnClick = ZeroClick
  end
  object Edit1: TEdit
    Left = 104
    Top = 96
    Width = 161
    Height = 21
    TabOrder = 3
    Text = 'Edit1'
  end
  object Edit2: TEdit
    Left = 104
    Top = 32
    Width = 161
    Height = 21
    TabOrder = 4
    Text = 'Edit2'
  end
  object Exit: TButton
    Left = 288
    Top = 88
    Width = 65
    Height = 25
    Caption = 'Exit'
    TabOrder = 5
    OnClick = ExitClick
  end
  object Timer1: TTimer
    Interval = 100
    OnTimer = Timer1Timer
    Left = 48
  end
  object Timer2: TTimer
    OnTimer = Timer2Timer
    Left = 16
  end
end
