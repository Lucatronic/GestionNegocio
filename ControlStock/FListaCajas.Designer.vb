﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FListaCajas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cajaa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraIni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoIni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblBuscar = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.LblAbrirCaja = New System.Windows.Forms.Label()
        Me.LblCerrarCaja = New System.Windows.Forms.Label()
        Me.LblResumenCaja = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Empleado, Me.Cajaa, Me.FechaIni, Me.HoraIni, Me.MontoIni, Me.FechaFin, Me.HoraFin, Me.MontoFin})
        Me.DataGridView1.Location = New System.Drawing.Point(15, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(738, 319)
        Me.DataGridView1.TabIndex = 16
        '
        'Empleado
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.Empleado.DefaultCellStyle = DataGridViewCellStyle2
        Me.Empleado.Frozen = True
        Me.Empleado.HeaderText = "Empleado"
        Me.Empleado.Name = "Empleado"
        Me.Empleado.ReadOnly = True
        Me.Empleado.Width = 150
        '
        'Cajaa
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Cajaa.DefaultCellStyle = DataGridViewCellStyle3
        Me.Cajaa.Frozen = True
        Me.Cajaa.HeaderText = "Caja"
        Me.Cajaa.Name = "Cajaa"
        Me.Cajaa.ReadOnly = True
        Me.Cajaa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cajaa.Width = 50
        '
        'FechaIni
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.FechaIni.DefaultCellStyle = DataGridViewCellStyle4
        Me.FechaIni.Frozen = True
        Me.FechaIni.HeaderText = "Fecha Apertura"
        Me.FechaIni.Name = "FechaIni"
        Me.FechaIni.ReadOnly = True
        Me.FechaIni.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FechaIni.Width = 110
        '
        'HoraIni
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.HoraIni.DefaultCellStyle = DataGridViewCellStyle5
        Me.HoraIni.Frozen = True
        Me.HoraIni.HeaderText = "Hora"
        Me.HoraIni.Name = "HoraIni"
        Me.HoraIni.ReadOnly = True
        Me.HoraIni.Width = 70
        '
        'MontoIni
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = "0"
        Me.MontoIni.DefaultCellStyle = DataGridViewCellStyle6
        Me.MontoIni.HeaderText = "Monto"
        Me.MontoIni.Name = "MontoIni"
        Me.MontoIni.ReadOnly = True
        Me.MontoIni.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MontoIni.Width = 80
        '
        'FechaFin
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.FechaFin.DefaultCellStyle = DataGridViewCellStyle7
        Me.FechaFin.HeaderText = "Fecha Cierre"
        Me.FechaFin.Name = "FechaFin"
        Me.FechaFin.ReadOnly = True
        Me.FechaFin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'HoraFin
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        Me.HoraFin.DefaultCellStyle = DataGridViewCellStyle8
        Me.HoraFin.HeaderText = "Hora"
        Me.HoraFin.Name = "HoraFin"
        Me.HoraFin.ReadOnly = True
        Me.HoraFin.Width = 70
        '
        'MontoFin
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.Format = "N0"
        DataGridViewCellStyle9.NullValue = Nothing
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.MontoFin.DefaultCellStyle = DataGridViewCellStyle9
        Me.MontoFin.HeaderText = "Monto"
        Me.MontoFin.Name = "MontoFin"
        Me.MontoFin.ReadOnly = True
        Me.MontoFin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MontoFin.Width = 80
        '
        'LblBuscar
        '
        Me.LblBuscar.AutoSize = True
        Me.LblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscar.ForeColor = System.Drawing.Color.White
        Me.LblBuscar.Location = New System.Drawing.Point(12, 10)
        Me.LblBuscar.Name = "LblBuscar"
        Me.LblBuscar.Size = New System.Drawing.Size(111, 13)
        Me.LblBuscar.TabIndex = 45
        Me.LblBuscar.Text = "Seleccione una fecha"
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(15, 26)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(108, 20)
        Me.DtpFecha.TabIndex = 54
        '
        'LblAbrirCaja
        '
        Me.LblAbrirCaja.AutoSize = True
        Me.LblAbrirCaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblAbrirCaja.Location = New System.Drawing.Point(517, 32)
        Me.LblAbrirCaja.Name = "LblAbrirCaja"
        Me.LblAbrirCaja.Size = New System.Drawing.Size(52, 13)
        Me.LblAbrirCaja.TabIndex = 56
        Me.LblAbrirCaja.Text = "Abrir Caja"
        '
        'LblCerrarCaja
        '
        Me.LblCerrarCaja.AutoSize = True
        Me.LblCerrarCaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblCerrarCaja.Location = New System.Drawing.Point(584, 32)
        Me.LblCerrarCaja.Name = "LblCerrarCaja"
        Me.LblCerrarCaja.Size = New System.Drawing.Size(59, 13)
        Me.LblCerrarCaja.TabIndex = 57
        Me.LblCerrarCaja.Text = "Cerrar Caja"
        '
        'LblResumenCaja
        '
        Me.LblResumenCaja.AutoSize = True
        Me.LblResumenCaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblResumenCaja.Location = New System.Drawing.Point(662, 32)
        Me.LblResumenCaja.Name = "LblResumenCaja"
        Me.LblResumenCaja.Size = New System.Drawing.Size(91, 13)
        Me.LblResumenCaja.TabIndex = 58
        Me.LblResumenCaja.Text = "Resumen de Caja"
        '
        'FListaCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(769, 394)
        Me.Controls.Add(Me.LblResumenCaja)
        Me.Controls.Add(Me.LblCerrarCaja)
        Me.Controls.Add(Me.LblAbrirCaja)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LblBuscar)
        Me.Controls.Add(Me.DtpFecha)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FListaCajas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apertura y Cierres"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LblBuscar As System.Windows.Forms.Label
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblAbrirCaja As Label
    Friend WithEvents LblCerrarCaja As Label
    Friend WithEvents LblResumenCaja As Label
    Friend WithEvents Empleado As DataGridViewTextBoxColumn
    Friend WithEvents Cajaa As DataGridViewTextBoxColumn
    Friend WithEvents FechaIni As DataGridViewTextBoxColumn
    Friend WithEvents HoraIni As DataGridViewTextBoxColumn
    Friend WithEvents MontoIni As DataGridViewTextBoxColumn
    Friend WithEvents FechaFin As DataGridViewTextBoxColumn
    Friend WithEvents HoraFin As DataGridViewTextBoxColumn
    Friend WithEvents MontoFin As DataGridViewTextBoxColumn
End Class
