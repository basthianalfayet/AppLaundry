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
        Me.TbljenisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New AppLaundry.DataSet1()
        Me.Tbl_pelangganTableAdapter = New AppLaundry.DataSet1TableAdapters.tbl_pelangganTableAdapter()
        Me.Tbl_jenisTableAdapter = New AppLaundry.DataSet1TableAdapters.tbl_jenisTableAdapter()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btntambahitem = New System.Windows.Forms.Button()
        Me.panelitem = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txttunai = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtkembalian = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.Label5.Location = New System.Drawing.Point(667, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Item Cucian"
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
        'Tbl_pelangganTableAdapter
        '
        Me.Tbl_pelangganTableAdapter.ClearBeforeFill = True
        '
        'Tbl_jenisTableAdapter
        '
        Me.Tbl_jenisTableAdapter.ClearBeforeFill = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(1072, 343)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 61
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btntambahitem
        '
        Me.btntambahitem.Location = New System.Drawing.Point(952, 343)
        Me.btntambahitem.Name = "btntambahitem"
        Me.btntambahitem.Size = New System.Drawing.Size(114, 23)
        Me.btntambahitem.TabIndex = 62
        Me.btntambahitem.Text = "Tambah Item Baru"
        Me.btntambahitem.UseVisualStyleBackColor = True
        '
        'panelitem
        '
        Me.panelitem.Location = New System.Drawing.Point(670, 25)
        Me.panelitem.Name = "panelitem"
        Me.panelitem.Size = New System.Drawing.Size(477, 202)
        Me.panelitem.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(957, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "TOTAL"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(1047, 233)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 65
        '
        'txttunai
        '
        Me.txttunai.Location = New System.Drawing.Point(1047, 262)
        Me.txttunai.Name = "txttunai"
        Me.txttunai.Size = New System.Drawing.Size(100, 20)
        Me.txttunai.TabIndex = 67
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(957, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "TUNAI"
        '
        'txtkembalian
        '
        Me.txtkembalian.Location = New System.Drawing.Point(1047, 290)
        Me.txtkembalian.Name = "txtkembalian"
        Me.txtkembalian.ReadOnly = True
        Me.txtkembalian.Size = New System.Drawing.Size(100, 20)
        Me.txtkembalian.TabIndex = 69
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(957, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "KEMBALIAN"
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 409)
        Me.Controls.Add(Me.txtkembalian)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txttunai)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.panelitem)
        Me.Controls.Add(Me.btntambahitem)
        Me.Controls.Add(Me.btnsimpan)
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
    Friend WithEvents DataSet11 As AppLaundry.DataSet1
    Friend WithEvents TbljenisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_jenisTableAdapter As AppLaundry.DataSet1TableAdapters.tbl_jenisTableAdapter
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btntambahitem As System.Windows.Forms.Button
    Friend WithEvents panelitem As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txttunai As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtkembalian As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
