<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvpelanggan = New System.Windows.Forms.DataGridView()
        Me.IdPelangganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPelangganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatPelangganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelpPelangganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KetPelangganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblpelangganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AppLaundry.DataSet1()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttelepon = New System.Windows.Forms.TextBox()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtidpelanggan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbjenis = New System.Windows.Forms.ComboBox()
        Me.TbljenisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New AppLaundry.DataSet1()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Tbl_pelangganTableAdapter = New AppLaundry.DataSet1TableAdapters.tbl_pelangganTableAdapter()
        Me.Tbl_jenisTableAdapter = New AppLaundry.DataSet1TableAdapters.tbl_jenisTableAdapter()
        Me.txttotalharga = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dgvpelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblpelangganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbljenisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvpelanggan
        '
        Me.dgvpelanggan.AutoGenerateColumns = False
        Me.dgvpelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpelanggan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPelangganDataGridViewTextBoxColumn, Me.NamaPelangganDataGridViewTextBoxColumn, Me.AlamatPelangganDataGridViewTextBoxColumn, Me.TelpPelangganDataGridViewTextBoxColumn, Me.KetPelangganDataGridViewTextBoxColumn})
        Me.dgvpelanggan.DataSource = Me.TblpelangganBindingSource
        Me.dgvpelanggan.Location = New System.Drawing.Point(12, 23)
        Me.dgvpelanggan.Name = "dgvpelanggan"
        Me.dgvpelanggan.Size = New System.Drawing.Size(632, 195)
        Me.dgvpelanggan.TabIndex = 28
        '
        'IdPelangganDataGridViewTextBoxColumn
        '
        Me.IdPelangganDataGridViewTextBoxColumn.DataPropertyName = "IdPelanggan"
        Me.IdPelangganDataGridViewTextBoxColumn.HeaderText = "IdPelanggan"
        Me.IdPelangganDataGridViewTextBoxColumn.Name = "IdPelangganDataGridViewTextBoxColumn"
        '
        'NamaPelangganDataGridViewTextBoxColumn
        '
        Me.NamaPelangganDataGridViewTextBoxColumn.DataPropertyName = "NamaPelanggan"
        Me.NamaPelangganDataGridViewTextBoxColumn.HeaderText = "NamaPelanggan"
        Me.NamaPelangganDataGridViewTextBoxColumn.Name = "NamaPelangganDataGridViewTextBoxColumn"
        '
        'AlamatPelangganDataGridViewTextBoxColumn
        '
        Me.AlamatPelangganDataGridViewTextBoxColumn.DataPropertyName = "AlamatPelanggan"
        Me.AlamatPelangganDataGridViewTextBoxColumn.HeaderText = "AlamatPelanggan"
        Me.AlamatPelangganDataGridViewTextBoxColumn.Name = "AlamatPelangganDataGridViewTextBoxColumn"
        '
        'TelpPelangganDataGridViewTextBoxColumn
        '
        Me.TelpPelangganDataGridViewTextBoxColumn.DataPropertyName = "TelpPelanggan"
        Me.TelpPelangganDataGridViewTextBoxColumn.HeaderText = "TelpPelanggan"
        Me.TelpPelangganDataGridViewTextBoxColumn.Name = "TelpPelangganDataGridViewTextBoxColumn"
        '
        'KetPelangganDataGridViewTextBoxColumn
        '
        Me.KetPelangganDataGridViewTextBoxColumn.DataPropertyName = "KetPelanggan"
        Me.KetPelangganDataGridViewTextBoxColumn.HeaderText = "KetPelanggan"
        Me.KetPelangganDataGridViewTextBoxColumn.Name = "KetPelangganDataGridViewTextBoxColumn"
        '
        'TblpelangganBindingSource
        '
        Me.TblpelangganBindingSource.DataMember = "tbl_pelanggan"
        Me.TblpelangganBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Keterangan"
        '
        'txttelepon
        '
        Me.txttelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelepon.Location = New System.Drawing.Point(102, 316)
        Me.txttelepon.Name = "txttelepon"
        Me.txttelepon.ReadOnly = True
        Me.txttelepon.Size = New System.Drawing.Size(521, 22)
        Me.txttelepon.TabIndex = 36
        '
        'txtketerangan
        '
        Me.txtketerangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtketerangan.Location = New System.Drawing.Point(102, 344)
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.ReadOnly = True
        Me.txtketerangan.Size = New System.Drawing.Size(214, 22)
        Me.txtketerangan.TabIndex = 37
        '
        'txtalamat
        '
        Me.txtalamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamat.Location = New System.Drawing.Point(102, 288)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.ReadOnly = True
        Me.txtalamat.Size = New System.Drawing.Size(521, 22)
        Me.txtalamat.TabIndex = 35
        '
        'txtnama
        '
        Me.txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(102, 260)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.ReadOnly = True
        Me.txtnama.Size = New System.Drawing.Size(521, 22)
        Me.txtnama.TabIndex = 34
        '
        'txtidpelanggan
        '
        Me.txtidpelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidpelanggan.Location = New System.Drawing.Point(102, 230)
        Me.txtidpelanggan.Name = "txtidpelanggan"
        Me.txtidpelanggan.ReadOnly = True
        Me.txtidpelanggan.Size = New System.Drawing.Size(521, 22)
        Me.txtidpelanggan.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Telepon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Id Pelanggan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(666, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Item Cucian"
        '
        'cmbjenis
        '
        Me.cmbjenis.DataSource = Me.TbljenisBindingSource
        Me.cmbjenis.DisplayMember = "NamaJenis"
        Me.cmbjenis.FormattingEnabled = True
        Me.cmbjenis.Location = New System.Drawing.Point(669, 81)
        Me.cmbjenis.Name = "cmbjenis"
        Me.cmbjenis.Size = New System.Drawing.Size(112, 21)
        Me.cmbjenis.TabIndex = 44
        Me.cmbjenis.ValueMember = "Harga"
        '
        'TbljenisBindingSource
        '
        Me.TbljenisBindingSource.DataMember = "tbl_jenis"
        Me.TbljenisBindingSource.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(666, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Jenis"
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(789, 81)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.ReadOnly = True
        Me.txtjumlah.Size = New System.Drawing.Size(89, 20)
        Me.txtjumlah.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(786, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Harga"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(882, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Jumlah"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(885, 81)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 48
        '
        'Tbl_pelangganTableAdapter
        '
        Me.Tbl_pelangganTableAdapter.ClearBeforeFill = True
        '
        'Tbl_jenisTableAdapter
        '
        Me.Tbl_jenisTableAdapter.ClearBeforeFill = True
        '
        'txttotalharga
        '
        Me.txttotalharga.AutoSize = True
        Me.txttotalharga.Location = New System.Drawing.Point(988, 65)
        Me.txttotalharga.Name = "txttotalharga"
        Me.txttotalharga.Size = New System.Drawing.Size(63, 13)
        Me.txttotalharga.TabIndex = 51
        Me.txttotalharga.Text = "Total Harga"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(991, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(89, 20)
        Me.TextBox1.TabIndex = 50
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(1086, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 23)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(988, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Total Harga"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(991, 130)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(89, 20)
        Me.TextBox3.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(882, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Jumlah"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(885, 130)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 57
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(786, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Harga"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(789, 130)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(89, 20)
        Me.TextBox5.TabIndex = 55
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(666, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Jenis"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TbljenisBindingSource
        Me.ComboBox1.DisplayMember = "NamaJenis"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(669, 130)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox1.TabIndex = 53
        Me.ComboBox1.ValueMember = "Harga"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1005, 343)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(885, 343)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 23)
        Me.Button3.TabIndex = 62
        Me.Button3.Text = "Tambah Item Baru"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 409)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txttotalharga)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbjenis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txttelepon)
        Me.Controls.Add(Me.txtketerangan)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtidpelanggan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvpelanggan)
        Me.Name = "FormTransaksi"
        Me.Text = "FormTransaksi"
        CType(Me.dgvpelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblpelangganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbljenisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvpelanggan As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As AppLaundry.DataSet1
    Friend WithEvents TblpelangganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_pelangganTableAdapter As AppLaundry.DataSet1TableAdapters.tbl_pelangganTableAdapter
    Friend WithEvents IdPelangganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaPelangganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatPelangganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelpPelangganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KetPelangganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttelepon As System.Windows.Forms.TextBox
    Friend WithEvents txtketerangan As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtidpelanggan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbjenis As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DataSet11 As AppLaundry.DataSet1
    Friend WithEvents TbljenisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_jenisTableAdapter As AppLaundry.DataSet1TableAdapters.tbl_jenisTableAdapter
    Friend WithEvents txttotalharga As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
