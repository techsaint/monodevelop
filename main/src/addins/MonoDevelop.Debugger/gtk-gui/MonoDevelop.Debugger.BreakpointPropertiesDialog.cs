
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Debugger
{
	public partial class BreakpointPropertiesDialog
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.Label label1;
		private global::Gtk.Table table1;
		private global::Gtk.Entry entryFile;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Entry entryLine;
		private global::Gtk.Label label4;
		private global::Gtk.Label label5;
		private global::Gtk.Label label6;
		private global::Gtk.Label label2;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Label label14;
		private global::Gtk.VBox boxConditionOptions;
		private global::Gtk.RadioButton radioBreakAlways;
		private global::Gtk.RadioButton radioBreakTrue;
		private global::Gtk.RadioButton radioBreakChange;
		private global::Gtk.HBox boxCondition;
		private global::Gtk.Label label15;
		private global::Gtk.Label label7;
		private global::Gtk.Entry entryCondition;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.HBox hbox7;
		private global::Gtk.Label label8;
		private global::Gtk.SpinButton spinHitCount;
		private global::Gtk.Label label3;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label label10;
		private global::Gtk.VBox boxAction;
		private global::Gtk.Label label11;
		private global::Gtk.RadioButton radioActionBreak;
		private global::Gtk.RadioButton radioActionTrace;
		private global::Gtk.HBox boxTraceExpression;
		private global::Gtk.Label label13;
		private global::Gtk.Label label12;
		private global::Gtk.Entry entryTraceExpr;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Debugger.BreakpointPropertiesDialog
			this.Name = "MonoDevelop.Debugger.BreakpointPropertiesDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Breakpoint Properties");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			// Internal child MonoDevelop.Debugger.BreakpointPropertiesDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(9));
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Location</b>");
			this.label1.UseMarkup = true;
			this.vbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(2)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.entryFile = new global::Gtk.Entry ();
			this.entryFile.CanFocus = true;
			this.entryFile.Name = "entryFile";
			this.entryFile.IsEditable = true;
			this.entryFile.InvisibleChar = '●';
			this.table1.Add (this.entryFile);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryFile]));
			w3.LeftAttach = ((uint)(2));
			w3.RightAttach = ((uint)(3));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entryLine = new global::Gtk.Entry ();
			this.entryLine.CanFocus = true;
			this.entryLine.Name = "entryLine";
			this.entryLine.IsEditable = true;
			this.entryLine.WidthChars = 10;
			this.entryLine.InvisibleChar = '●';
			this.hbox1.Add (this.entryLine);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entryLine]));
			w4.Position = 0;
			this.table1.Add (this.hbox1);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox1]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.LeftAttach = ((uint)(2));
			w5.RightAttach = ((uint)(3));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("File:");
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Line:");
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.WidthRequest = 12;
			this.label6.Name = "label6";
			this.table1.Add (this.label6);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.label6]));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add (this.table1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.table1]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Condition</b>");
			this.label2.UseMarkup = true;
			this.vbox2.Add (this.label2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label2]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label14 = new global::Gtk.Label ();
			this.label14.WidthRequest = 12;
			this.label14.Name = "label14";
			this.hbox4.Add (this.label14);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label14]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.boxConditionOptions = new global::Gtk.VBox ();
			this.boxConditionOptions.Name = "boxConditionOptions";
			this.boxConditionOptions.Spacing = 6;
			// Container child boxConditionOptions.Gtk.Box+BoxChild
			this.radioBreakAlways = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Always break"));
			this.radioBreakAlways.CanFocus = true;
			this.radioBreakAlways.Name = "radioBreakAlways";
			this.radioBreakAlways.Active = true;
			this.radioBreakAlways.DrawIndicator = true;
			this.radioBreakAlways.UseUnderline = true;
			this.radioBreakAlways.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.boxConditionOptions.Add (this.radioBreakAlways);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.boxConditionOptions [this.radioBreakAlways]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child boxConditionOptions.Gtk.Box+BoxChild
			this.radioBreakTrue = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Break when condition is true"));
			this.radioBreakTrue.CanFocus = true;
			this.radioBreakTrue.Name = "radioBreakTrue";
			this.radioBreakTrue.DrawIndicator = true;
			this.radioBreakTrue.UseUnderline = true;
			this.radioBreakTrue.Group = this.radioBreakAlways.Group;
			this.boxConditionOptions.Add (this.radioBreakTrue);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.boxConditionOptions [this.radioBreakTrue]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child boxConditionOptions.Gtk.Box+BoxChild
			this.radioBreakChange = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Break when the expression changes"));
			this.radioBreakChange.CanFocus = true;
			this.radioBreakChange.Name = "radioBreakChange";
			this.radioBreakChange.DrawIndicator = true;
			this.radioBreakChange.UseUnderline = true;
			this.radioBreakChange.Group = this.radioBreakAlways.Group;
			this.boxConditionOptions.Add (this.radioBreakChange);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.boxConditionOptions [this.radioBreakChange]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			// Container child boxConditionOptions.Gtk.Box+BoxChild
			this.boxCondition = new global::Gtk.HBox ();
			this.boxCondition.Name = "boxCondition";
			this.boxCondition.Spacing = 6;
			// Container child boxCondition.Gtk.Box+BoxChild
			this.label15 = new global::Gtk.Label ();
			this.label15.WidthRequest = 12;
			this.label15.Name = "label15";
			this.boxCondition.Add (this.label15);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.boxCondition [this.label15]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child boxCondition.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 0F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Condition expression:");
			this.boxCondition.Add (this.label7);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.boxCondition [this.label7]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			// Container child boxCondition.Gtk.Box+BoxChild
			this.entryCondition = new global::Gtk.Entry ();
			this.entryCondition.CanFocus = true;
			this.entryCondition.Name = "entryCondition";
			this.entryCondition.IsEditable = true;
			this.entryCondition.InvisibleChar = '●';
			this.boxCondition.Add (this.entryCondition);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.boxCondition [this.entryCondition]));
			w17.Position = 2;
			this.boxConditionOptions.Add (this.boxCondition);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.boxConditionOptions [this.boxCondition]));
			w18.Position = 3;
			// Container child boxConditionOptions.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.boxConditionOptions.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.boxConditionOptions [this.hseparator1]));
			w19.Position = 4;
			w19.Expand = false;
			w19.Fill = false;
			// Container child boxConditionOptions.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 0F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Hit count before breaking:");
			this.hbox7.Add (this.label8);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.label8]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.spinHitCount = new global::Gtk.SpinButton (0, 100000000, 1);
			this.spinHitCount.CanFocus = true;
			this.spinHitCount.Name = "spinHitCount";
			this.spinHitCount.Adjustment.PageIncrement = 10;
			this.spinHitCount.ClimbRate = 1;
			this.spinHitCount.Numeric = true;
			this.spinHitCount.Value = 1;
			this.hbox7.Add (this.spinHitCount);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.spinHitCount]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			this.boxConditionOptions.Add (this.hbox7);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.boxConditionOptions [this.hbox7]));
			w22.Position = 5;
			w22.Expand = false;
			w22.Fill = false;
			this.hbox4.Add (this.boxConditionOptions);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.boxConditionOptions]));
			w23.Position = 1;
			this.vbox2.Add (this.hbox4);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox4]));
			w24.Position = 3;
			w24.Expand = false;
			w24.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Action</b>");
			this.label3.UseMarkup = true;
			this.vbox2.Add (this.label3);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label3]));
			w25.Position = 4;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label ();
			this.label10.WidthRequest = 12;
			this.label10.Name = "label10";
			this.hbox2.Add (this.label10);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label10]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.boxAction = new global::Gtk.VBox ();
			this.boxAction.Name = "boxAction";
			this.boxAction.Spacing = 6;
			// Container child boxAction.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.Xalign = 0F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("When the breakpoint is hit:");
			this.boxAction.Add (this.label11);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.boxAction [this.label11]));
			w27.Position = 0;
			w27.Expand = false;
			w27.Fill = false;
			// Container child boxAction.Gtk.Box+BoxChild
			this.radioActionBreak = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Break"));
			this.radioActionBreak.CanFocus = true;
			this.radioActionBreak.Name = "radioActionBreak";
			this.radioActionBreak.Active = true;
			this.radioActionBreak.DrawIndicator = true;
			this.radioActionBreak.UseUnderline = true;
			this.radioActionBreak.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.boxAction.Add (this.radioActionBreak);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.boxAction [this.radioActionBreak]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			// Container child boxAction.Gtk.Box+BoxChild
			this.radioActionTrace = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Write expression to the output"));
			this.radioActionTrace.CanFocus = true;
			this.radioActionTrace.Name = "radioActionTrace";
			this.radioActionTrace.DrawIndicator = true;
			this.radioActionTrace.UseUnderline = true;
			this.radioActionTrace.Group = this.radioActionBreak.Group;
			this.boxAction.Add (this.radioActionTrace);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.boxAction [this.radioActionTrace]));
			w29.Position = 2;
			w29.Expand = false;
			w29.Fill = false;
			// Container child boxAction.Gtk.Box+BoxChild
			this.boxTraceExpression = new global::Gtk.HBox ();
			this.boxTraceExpression.Name = "boxTraceExpression";
			this.boxTraceExpression.Spacing = 6;
			// Container child boxTraceExpression.Gtk.Box+BoxChild
			this.label13 = new global::Gtk.Label ();
			this.label13.WidthRequest = 12;
			this.label13.Name = "label13";
			this.boxTraceExpression.Add (this.label13);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.boxTraceExpression [this.label13]));
			w30.Position = 0;
			w30.Expand = false;
			w30.Fill = false;
			// Container child boxTraceExpression.Gtk.Box+BoxChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Expression:");
			this.boxTraceExpression.Add (this.label12);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.boxTraceExpression [this.label12]));
			w31.Position = 1;
			w31.Expand = false;
			w31.Fill = false;
			// Container child boxTraceExpression.Gtk.Box+BoxChild
			this.entryTraceExpr = new global::Gtk.Entry ();
			this.entryTraceExpr.CanFocus = true;
			this.entryTraceExpr.Name = "entryTraceExpr";
			this.entryTraceExpr.IsEditable = true;
			this.entryTraceExpr.InvisibleChar = '●';
			this.boxTraceExpression.Add (this.entryTraceExpr);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.boxTraceExpression [this.entryTraceExpr]));
			w32.Position = 2;
			this.boxAction.Add (this.boxTraceExpression);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.boxAction [this.boxTraceExpression]));
			w33.Position = 3;
			w33.Expand = false;
			w33.Fill = false;
			this.hbox2.Add (this.boxAction);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.boxAction]));
			w34.Position = 1;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w35.Position = 5;
			w35.Expand = false;
			w35.Fill = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w36.Position = 0;
			w36.Expand = false;
			w36.Fill = false;
			// Internal child MonoDevelop.Debugger.BreakpointPropertiesDialog.ActionArea
			global::Gtk.HButtonBox w37 = this.ActionArea;
			w37.Name = "dialog1_ActionArea";
			w37.Spacing = 6;
			w37.BorderWidth = ((uint)(5));
			w37.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w38 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w37 [this.buttonCancel]));
			w38.Expand = false;
			w38.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			w37.Add (this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w39 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w37 [this.buttonOk]));
			w39.Position = 1;
			w39.Expand = false;
			w39.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 512;
			this.DefaultHeight = 438;
			this.Hide ();
			this.radioBreakAlways.Toggled += new global::System.EventHandler (this.OnRadioBreakAlwaysToggled);
			this.radioBreakTrue.Toggled += new global::System.EventHandler (this.OnRadioBreakAlwaysToggled);
			this.radioBreakChange.Toggled += new global::System.EventHandler (this.OnRadioBreakAlwaysToggled);
			this.radioActionBreak.Toggled += new global::System.EventHandler (this.OnRadioActionBreakToggled);
			this.radioActionTrace.Toggled += new global::System.EventHandler (this.OnRadioActionBreakToggled);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
