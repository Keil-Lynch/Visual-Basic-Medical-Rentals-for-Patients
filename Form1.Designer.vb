<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentalCost
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
        Me.btnDisplayRates = New System.Windows.Forms.Button()
        Me.btnDisplayBill = New System.Windows.Forms.Button()
        Me.lstRentalRates = New System.Windows.Forms.ListBox()
        Me.lstBill = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDisplayRates
        '
        Me.btnDisplayRates.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayRates.Location = New System.Drawing.Point(12, 35)
        Me.btnDisplayRates.Name = "btnDisplayRates"
        Me.btnDisplayRates.Size = New System.Drawing.Size(191, 34)
        Me.btnDisplayRates.TabIndex = 0
        Me.btnDisplayRates.Text = "Display Rental Rates"
        Me.btnDisplayRates.UseVisualStyleBackColor = True
        '
        'btnDisplayBill
        '
        Me.btnDisplayBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayBill.Location = New System.Drawing.Point(12, 187)
        Me.btnDisplayBill.Name = "btnDisplayBill"
        Me.btnDisplayBill.Size = New System.Drawing.Size(191, 34)
        Me.btnDisplayBill.TabIndex = 1
        Me.btnDisplayBill.Text = "Display Patient Bill"
        Me.btnDisplayBill.UseVisualStyleBackColor = True
        '
        'lstRentalRates
        '
        Me.lstRentalRates.FormattingEnabled = True
        Me.lstRentalRates.Location = New System.Drawing.Point(221, 16)
        Me.lstRentalRates.Name = "lstRentalRates"
        Me.lstRentalRates.Size = New System.Drawing.Size(436, 82)
        Me.lstRentalRates.TabIndex = 2
        '
        'lstBill
        '
        Me.lstBill.FormattingEnabled = True
        Me.lstBill.Location = New System.Drawing.Point(221, 113)
        Me.lstBill.Name = "lstBill"
        Me.lstBill.Size = New System.Drawing.Size(436, 134)
        Me.lstBill.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select an item (1, 2, or 3)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select a duration (H or F)"
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(168, 117)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(35, 20)
        Me.txtItem.TabIndex = 6
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(168, 154)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(35, 20)
        Me.txtDuration.TabIndex = 7
        '
        'frmRentalCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 261)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstBill)
        Me.Controls.Add(Me.lstRentalRates)
        Me.Controls.Add(Me.btnDisplayBill)
        Me.Controls.Add(Me.btnDisplayRates)
        Me.Name = "frmRentalCost"
        Me.Text = "Medical Rentals for Patients                                                     " &
    "                                   "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDisplayRates As Button
    Friend WithEvents btnDisplayBill As Button
    Friend WithEvents lstRentalRates As ListBox
    Friend WithEvents lstBill As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtItem As TextBox
    Friend WithEvents txtDuration As TextBox
End Class
