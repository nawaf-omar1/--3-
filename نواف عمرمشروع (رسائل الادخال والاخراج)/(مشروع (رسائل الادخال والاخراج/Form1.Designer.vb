﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(71, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "حول المشروع"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(71, 58)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(158, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "خروج"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(71, 87)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(158, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "صندوق ادخال الالوان"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(71, 116)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(158, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "الالوان العشوائية"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(71, 145)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(158, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "الكتابة على عدة سطور"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(71, 186)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 20)
        Me.TextBox1.TabIndex = 5
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(51, 186)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 20)
        Me.VScrollBar1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(117, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 296)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "رسائل الادخال و الاخراج"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents Label1 As Label
End Class
