
// This file has been generated by the GUI designer. Do not modify.
namespace PubnubMessagingExampleGTK
{
	public partial class SettingsDialog
	{
		private global::Gtk.Fixed mainFixedPanel;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.Label label78;
		private global::Gtk.HSeparator hseparator2;
		private global::Gtk.Label label79;
		private global::Gtk.Label label81;
		private global::Gtk.Entry entryCipher;
		private global::Gtk.Entry entryUuid;
		private global::Gtk.Label label83;
		private global::Gtk.Entry entryChannel;
		private global::Gtk.Expander expander2;
		private global::Gtk.Fixed fixed5;
		private global::Gtk.Entry entryServer;
		private global::Gtk.Entry entryPort;
		private global::Gtk.Label label84;
		private global::Gtk.Label label85;
		private global::Gtk.Entry entryUsername;
		private global::Gtk.Label label2;
		private global::Gtk.Label lblUsername;
		private global::Gtk.Entry entryPassword;
		private global::Gtk.Label GtkLabel2;
		private global::Gtk.Label label75;
		private global::Gtk.Label label76;
		private global::Gtk.Label label80;
		private global::Gtk.Label label82;
		private global::Gtk.ToggleButton sslToggle;
		private global::Gtk.Button btnCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget PubnubMessagingExampleGTK.SettingsDialog
			this.Name = "PubnubMessagingExampleGTK.SettingsDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Settings");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			this.AllowGrow = false;
			this.DefaultWidth = 420;
			this.DefaultHeight = 420;
			// Internal child PubnubMessagingExampleGTK.SettingsDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.mainFixedPanel = new global::Gtk.Fixed ();
			this.mainFixedPanel.HeightRequest = 420;
			this.mainFixedPanel.Name = "mainFixedPanel";
			this.mainFixedPanel.HasWindow = false;
			// Container child mainFixedPanel.Gtk.Fixed+FixedChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.WidthRequest = 550;
			this.hseparator1.HeightRequest = 1;
			this.hseparator1.Name = "hseparator1";
			this.mainFixedPanel.Add (this.hseparator1);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.mainFixedPanel [this.hseparator1]));
			w2.X = 1;
			w2.Y = 39;
			// Container child mainFixedPanel.Gtk.Fixed+FixedChild
			this.label78 = new global::Gtk.Label ();
			this.label78.Name = "label78";
			this.label78.LabelProp = global::Mono.Unix.Catalog.GetString ("Channel(s)");
			this.mainFixedPanel.Add (this.label78);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.mainFixedPanel [this.label78]));
			w3.X = 31;
			w3.Y = 67;
			// Container child mainFixedPanel.Gtk.Fixed+FixedChild
			this.hseparator2 = new global::Gtk.HSeparator ();
			this.hseparator2.WidthRequest = 550;
			this.hseparator2.HeightRequest = 1;
			this.hseparator2.Name = "hseparator2";
			this.mainFixedPanel.Add (this.hseparator2);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.mainFixedPanel [this.hseparator2]));
			w4.Y = 122;
			// Container child mainFixedPanel.Gtk.Fixed+FixedChild
			this.label79 = new global::Gtk.Label ();
			this.label79.Name = "label79";
			this.label79.LabelProp = global::Mono.Unix.Catalog.GetString ("SSL");
			this.mainFixedPanel.Add (this.label79);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.mainFixedPanel [this.label79]));
			w5.X = 32;
			w5.Y = 96;
			// Container child mainFixedPanel.Gtk.Fixed+FixedChild
			this.label81 = new global::Gtk.Label ();
			this.label81.Name = "label81";
			this.label81.LabelProp = global::Mono.Unix.Catalog.GetString ("Cipher");
			this.mainFixedPanel.Add (this.label81);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.mainFixedPanel [this.label81]));
			w6.X = 34;
			w6.Y = 152;
			// Container child mainFixedPanel.Gtk.Fixed+FixedChild
			this.entryCipher = new global::Gtk.Entry ();
			this.entryCipher.CanFocus = true;
			this.entryCipher.Name = "entryCipher";
			this.entryCipher.IsEditable = true;
			this.entryCipher.InvisibleChar = '•';
			this.mainFixedPanel.Add (this.entryCipher);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.mainFixedPanel [this.entryCipher]));
			w7.X = 139;
			w7.Y = 147;
			// Container child mainFixedPanel.Gtk.Fixed+FixedChild
			this.entryUuid = new global::Gtk.Entry ();
			this.entryUuid.CanFocus = true;
			this.entryUuid.Name = "entryUuid";
			this.entryUuid.IsEditable = true;
			this.entryUuid.InvisibleChar = '•';
			this.mainFixedPanel.Add (this.entryUuid);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.mainFixedPanel [this.entryUuid]));
			w8.X = 139;
			w8.Y = 207;
			// Container child mainFixedPanel.Gtk.Fixed+FixedChild
			this.label83 = new global::Gtk.Label ();
			this.label83.Name = "label83";
			this.label83.LabelProp = global::Mono.Unix.Catalog.GetString ("Custom UUID");
			this.mainFixedPanel.Add (this.label83);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.mainFixedPanel [this.label83]));
			w9.X = 33;
			w9.Y = 209;
			// Container child mainFixedPanel.Gtk.Fixed+FixedChild
			this.entryChannel = new global::Gtk.Entry ();
			this.entryChannel.WidthRequest = 300;
			this.entryChannel.CanFocus = true;
			this.entryChannel.Name = "entryChannel";
			this.entryChannel.IsEditable = true;
			this.entryChannel.InvisibleChar = '•';
			this.mainFixedPanel.Add (this.entryChannel);
			global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.mainFixedPanel [this.entryChannel]));
			w10.X = 141;
			w10.Y = 62;
			// Container child mainFixedPanel.Gtk.Fixed+FixedChild
			this.expander2 = new global::Gtk.Expander (null);
			this.expander2.HeightRequest = 170;
			this.expander2.CanFocus = true;
			this.expander2.Name = "expander2";
			this.expander2.Expanded = true;
			// Container child expander2.Gtk.Container+ContainerChild
			this.fixed5 = new global::Gtk.Fixed ();
			this.fixed5.WidthRequest = 400;
			this.fixed5.HeightRequest = 135;
			this.fixed5.Name = "fixed5";
			this.fixed5.HasWindow = false;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.entryServer = new global::Gtk.Entry ();
			this.entryServer.CanFocus = true;
			this.entryServer.Name = "entryServer";
			this.entryServer.IsEditable = true;
			this.entryServer.InvisibleChar = '•';
			this.fixed5.Add (this.entryServer);
			global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.entryServer]));
			w11.X = 129;
			w11.Y = 10;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.entryPort = new global::Gtk.Entry ();
			this.entryPort.CanFocus = true;
			this.entryPort.Name = "entryPort";
			this.entryPort.IsEditable = true;
			this.entryPort.InvisibleChar = '•';
			this.fixed5.Add (this.entryPort);
			global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.entryPort]));
			w12.X = 129;
			w12.Y = 43;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.label84 = new global::Gtk.Label ();
			this.label84.Name = "label84";
			this.label84.LabelProp = global::Mono.Unix.Catalog.GetString ("Server");
			this.fixed5.Add (this.label84);
			global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.label84]));
			w13.X = 26;
			w13.Y = 16;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.label85 = new global::Gtk.Label ();
			this.label85.Name = "label85";
			this.label85.LabelProp = global::Mono.Unix.Catalog.GetString ("Port");
			this.fixed5.Add (this.label85);
			global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.label85]));
			w14.X = 26;
			w14.Y = 45;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.entryUsername = new global::Gtk.Entry ();
			this.entryUsername.CanFocus = true;
			this.entryUsername.Name = "entryUsername";
			this.entryUsername.IsEditable = true;
			this.entryUsername.InvisibleChar = '•';
			this.fixed5.Add (this.entryUsername);
			global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.entryUsername]));
			w15.X = 129;
			w15.Y = 75;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Password");
			this.fixed5.Add (this.label2);
			global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.label2]));
			w16.X = 26;
			w16.Y = 112;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.lblUsername = new global::Gtk.Label ();
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.LabelProp = global::Mono.Unix.Catalog.GetString ("Username");
			this.fixed5.Add (this.lblUsername);
			global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.lblUsername]));
			w17.X = 26;
			w17.Y = 79;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.entryPassword = new global::Gtk.Entry ();
			this.entryPassword.CanFocus = true;
			this.entryPassword.Name = "entryPassword";
			this.entryPassword.IsEditable = true;
			this.entryPassword.InvisibleChar = '•';
			this.fixed5.Add (this.entryPassword);
			global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.entryPassword]));
			w18.X = 128;
			w18.Y = 109;
			this.expander2.Add (this.fixed5);
			this.GtkLabel2 = new global::Gtk.Label ();
			this.GtkLabel2.HeightRequest = 0;
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("Proxy Settings");
			this.GtkLabel2.UseUnderline = true;
			this.expander2.LabelWidget = this.GtkLabel2;
			this.mainFixedPanel.Add (this.expander2);
			global::Gtk.Fixed.FixedChild w20 = ((global::Gtk.Fixed.FixedChild)(this.mainFixedPanel [this.expander2]));
			w20.X = 26;
			w20.Y = 246;
			// Container child mainFixedPanel.Gtk.Fixed+FixedChild
			this.label75 = new global::Gtk.Label ();
			this.label75.Name = "label75";
			this.label75.LabelProp = global::Mono.Unix.Catalog.GetString ("Basic Settings");
			this.mainFixedPanel.Add (this.label75);
			global::Gtk.Fixed.FixedChild w21 = ((global::Gtk.Fixed.FixedChild)(this.mainFixedPanel [this.label75]));
			w21.X = 225;
			w21.Y = 13;
			// Container child mainFixedPanel.Gtk.Fixed+FixedChild
			this.label76 = new global::Gtk.Label ();
			this.label76.Name = "label76";
			this.label76.LabelProp = global::Mono.Unix.Catalog.GetString ("Enter multiple channels separated by comma");
			this.mainFixedPanel.Add (this.label76);
			global::Gtk.Fixed.FixedChild w22 = ((global::Gtk.Fixed.FixedChild)(this.mainFixedPanel [this.label76]));
			w22.X = 127;
			w22.Y = 42;
			// Container child mainFixedPanel.Gtk.Fixed+FixedChild
			this.label80 = new global::Gtk.Label ();
			this.label80.Name = "label80";
			this.label80.LabelProp = global::Mono.Unix.Catalog.GetString ("Enter cipher for encryption or leave blank for unencrypted transfer");
			this.mainFixedPanel.Add (this.label80);
			global::Gtk.Fixed.FixedChild w23 = ((global::Gtk.Fixed.FixedChild)(this.mainFixedPanel [this.label80]));
			w23.X = 61;
			w23.Y = 126;
			// Container child mainFixedPanel.Gtk.Fixed+FixedChild
			this.label82 = new global::Gtk.Label ();
			this.label82.Name = "label82";
			this.label82.LabelProp = global::Mono.Unix.Catalog.GetString ("Enter custom UUID or leave blank for default UUID");
			this.mainFixedPanel.Add (this.label82);
			global::Gtk.Fixed.FixedChild w24 = ((global::Gtk.Fixed.FixedChild)(this.mainFixedPanel [this.label82]));
			w24.X = 104;
			w24.Y = 181;
			// Container child mainFixedPanel.Gtk.Fixed+FixedChild
			this.sslToggle = new global::Gtk.ToggleButton ();
			this.sslToggle.CanFocus = true;
			this.sslToggle.Name = "sslToggle";
			this.sslToggle.UseUnderline = true;
			this.sslToggle.Active = true;
			this.sslToggle.Label = global::Mono.Unix.Catalog.GetString ("Off");
			this.mainFixedPanel.Add (this.sslToggle);
			global::Gtk.Fixed.FixedChild w25 = ((global::Gtk.Fixed.FixedChild)(this.mainFixedPanel [this.sslToggle]));
			w25.X = 139;
			w25.Y = 93;
			w1.Add (this.mainFixedPanel);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(w1 [this.mainFixedPanel]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Internal child PubnubMessagingExampleGTK.SettingsDialog.ActionArea
			global::Gtk.HButtonBox w27 = this.ActionArea;
			w27.Name = "dialog1_ActionArea";
			w27.Spacing = 10;
			w27.BorderWidth = ((uint)(5));
			w27.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.btnCancel = new global::Gtk.Button ();
			this.btnCancel.CanDefault = true;
			this.btnCancel.CanFocus = true;
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.UseStock = true;
			this.btnCancel.UseUnderline = true;
			this.btnCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.btnCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w28 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w27 [this.btnCancel]));
			w28.Expand = false;
			w28.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			w27.Add (this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w29 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w27 [this.buttonOk]));
			w29.Position = 1;
			w29.Expand = false;
			w29.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.expander2.Activated += new global::System.EventHandler (this.ProxyExpanderActivated);
			this.sslToggle.Toggled += new global::System.EventHandler (this.SslToggled);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OkClicked);
		}
	}
}
