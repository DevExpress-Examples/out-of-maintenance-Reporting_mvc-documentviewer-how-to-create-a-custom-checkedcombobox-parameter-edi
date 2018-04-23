Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Drawing
Imports System.Web
Imports System.Web.UI
Imports DevExpress.Web
Imports System.Web.UI.WebControls

Namespace T262163.Templates
	Public Class CheckedListWindowTemplate
		Implements ITemplate

		Private _settings As CheckedListWindowSettings

		Public Sub New(ByVal settings As CheckedListWindowSettings)
			Me._settings = settings
		End Sub

		Protected ReadOnly Property Settings() As CheckedListWindowSettings
			Get
				Return _settings
			End Get
		End Property

		Public Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
			Dim listBox As New ASPxListBox() With {.ID = Settings.ListBoxName}
			container.Controls.Add(listBox)

			listBox.ClientInstanceName = Settings.ListBoxName
			listBox.Border.BorderWidth = 0
			listBox.BorderBottom.BorderWidth = 1
			listBox.BorderBottom.BorderColor = Color.FromArgb(&HDCDCDC)
			listBox.Width = Unit.Percentage(100)

			listBox.SelectionMode = ListEditSelectionMode.CheckColumn
			listBox.ClientSideEvents.SelectedIndexChanged = String.Format("function(s, e){{ OnListBoxSelectionChanged(s, e, {0}); }}", Settings.CheckComboBoxName)

			If Settings.DataSource Is Nothing Then
				listBox.Items.AddRange(Settings.Items)
				listBox.Items.Insert(0, New ListEditItem("(Select all)"))
			Else
				listBox.TextField = Settings.TextField
				listBox.ValueField = Settings.TextField
				listBox.ValueType = GetType(String)
				listBox.DataSource = Settings.DataSource
				AddHandler listBox.DataBound, AddressOf listBox_DataBound
				listBox.DataBindItems()
			End If

			container.Controls.Add(New LiteralControl("<div style=""padding: 6px; height: 24px;"">"))

			Dim button As New ASPxButton() With {.ID = Settings.CloseButtonName}
			container.Controls.Add(button)

			button.ClientInstanceName = Settings.CloseButtonName
			button.Text = "Close"
			button.Style.Add("float", "right")
			button.Style.Add("padding", "0px 2px")
			button.ClientSideEvents.Click = String.Format("function(s, e){{ {0}.HideDropDown(); }}", Settings.CheckComboBoxName)
			button.Height = 26

			container.Controls.Add(New LiteralControl("</div>"))
		End Sub

		Private Sub listBox_DataBound(ByVal sender As Object, ByVal e As EventArgs)
			Dim listBox As ASPxListBox = TryCast(sender, ASPxListBox)
			listBox.Items.Insert(0, New ListEditItem("(Select all)"))
		End Sub
	End Class

	Public Class CheckedListWindowSettings
		Private _checkComboBoxName As String
		Private _items As ListEditItemCollection

		Public Sub New(ByVal checkComboBoxName As String)
			Me._items = New ListEditItemCollection()
			Me._checkComboBoxName = checkComboBoxName
			Me.TextField = String.Empty
			Me.DataSource = Nothing
		End Sub

		Public ReadOnly Property CheckComboBoxName() As String
			Get
				Return _checkComboBoxName
			End Get
		End Property
		Public ReadOnly Property ListBoxName() As String
			Get
				Return String.Format("{0}_ListBox", Me.CheckComboBoxName)
			End Get
		End Property
		Public ReadOnly Property CloseButtonName() As String
			Get
				Return String.Format("{0}_ButtonClose", Me.CheckComboBoxName)
			End Get
		End Property
		Public ReadOnly Property Items() As ListEditItemCollection
			Get
				Return _items
			End Get
		End Property

		Public Property TextField() As String
		Public Property DataSource() As Object
	End Class
End Namespace