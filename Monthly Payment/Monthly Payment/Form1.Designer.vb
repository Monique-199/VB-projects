﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCalculate = New System.Windows.Forms.Button()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCalculate
        '
        Me.lblCalculate.Location = New System.Drawing.Point(138, 199)
        Me.lblCalculate.Name = "lblCalculate"
        Me.lblCalculate.Size = New System.Drawing.Size(75, 23)
        Me.lblCalculate.TabIndex = 0
        Me.lblCalculate.Text = "Calculate"
        Me.lblCalculate.UseVisualStyleBackColor = True
        '
        'lblPay
        '
        Me.lblPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPay.Location = New System.Drawing.Point(138, 129)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(100, 23)
        Me.lblPay.TabIndex = 1
        Me.lblPay.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 450)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.lblCalculate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCalculate As Button
    Friend WithEvents lblPay As Label
End Class
