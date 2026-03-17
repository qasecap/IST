using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Text; 

 
	partial class DynamicControls : System.Web.UI.Page
	{
	//protected System.Web.UI.WebControls.TextBox TextBox1;
	//protected System.Web.UI.WebControls.Label lblResult;
	//protected System.Web.UI.WebControls.Label lblText;
	//protected System.Web.UI.WebControls.Button cmdAdd;
	//protected System.Web.UI.WebControls.Button Button1;
	//protected System.Web.UI.WebControls.Label Label1;
	//protected System.Web.UI.HtmlControls.HtmlForm Form1;

	private struct ControlInfo
	{
		public string ID;
		public string Type;
		public int Top;
		public int Left;
		public string EventHandler;
	}

	private void Page_Load(object sender, System.EventArgs e)
	{
		if (!this.IsPostBack)
		{
            // Initialize controls number.
            // Used to create control id
           // this.Session["DynamicControls"] == Null;
            this.Session.Add("LastControl", 2);
		}
		else
		{
			// Recreate controls created on previous roundtrips
			RecreatePersistedControls();
		}
	}


	#region Web Form Designer generated code
	override protected void OnInit(EventArgs e)
	{
		//
		// CODEGEN: This call is required by the ASP.NET Web Form Designer.
		//
		InitializeComponent();
		base.OnInit(e);
	}

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		this.cmdAdd.Click += new System.EventHandler(this.Button1_Click);
		this.TextBox1.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
		this.Button1.Click += new System.EventHandler(this.Button_Click);
		this.Load += new System.EventHandler(this.Page_Load);

	}
	#endregion

	// Call CreateControl for each persisted control
	private void RecreatePersistedControls()
	{
		ArrayList al = (ArrayList)this.Session["DynamicControls"];
		if (al != null)
		{
			foreach (ControlInfo ci in al)
			{
				this.CreateControl(ci);
			}
		}
	}
	// Create control specified by ControlInfo structure
	private Control CreateControl(ControlInfo ci)
	{
		Control ctl = null;
		switch (ci.Type)
		{
			case "Button":
				ctl = new Button();
				((Button)ctl).Style["Position"] = "Absolute";
				((Button)ctl).Style["Top"] = ci.Top.ToString();
				((Button)ctl).Style["Left"] = ci.Left.ToString();
				this.AppendEvent(ctl, ci.EventHandler);
				break;
			case "TextBox":
				ctl = new TextBox();
				((TextBox)ctl).Style["Position"] = "Absolute";
				((TextBox)ctl).Style["Top"] = ci.Top.ToString();
				((TextBox)ctl).Style["Left"] = ci.Left.ToString();
				this.AppendEvent(ctl, ci.EventHandler);
				break;
			case "Label":
				ctl = new Label();
				((Label)ctl).Style["Position"] = "Absolute";
				((Label)ctl).Style["Top"] = ci.Top.ToString();
				((Label)ctl).Style["Left"] = ci.Left.ToString();
				break;
			default:
				return null;
		}
		ctl.ID = ci.ID;
		this.Form1.Controls.Add(ctl);
		return ctl;
	}
	// Set Event handler
	private void AppendEvent(Control ctl, string handler)
	{
		switch (handler)
		{
			case "Click":
				((Button)ctl).Click += new System.EventHandler(this.Button_Click);
				break;

			case "TextChanged":
				((TextBox)ctl).TextChanged += new System.EventHandler(this.TextBox_TextChanged);
				break;
		}
	}
	// Create ControlInfo structure and persist it to Session
	private ControlInfo PersistControl(string id, string type,
		int top, int left, string eventHandler)
	{
		ControlInfo ci = new ControlInfo();
		ci.ID = id;
		ci.Type = type;
		ci.Top = top;
		ci.Left = left;
		ci.EventHandler = eventHandler;

		ArrayList al = (ArrayList)this.Session["DynamicControls"];
		if (al == null)
		{
			al = new ArrayList();
		}
		al.Add(ci);
		this.Session["DynamicControls"] = al;
		return ci;
	}


	#region Event Handlers for new controls
	private void Button_Click(object sender, System.EventArgs e)
	{
		this.lblResult.Text = ((Button)sender).Text + " clicked";
	}

	private void TextBox_TextChanged(object sender, System.EventArgs e)
	{
		this.lblText.Text = ((TextBox)sender).Text + " text changed";
	}

	#endregion

	private const int TOP = 96;
	private const int HEIGHT = 48;
	private const int BUTTON_LEFT = 48;
	private const int TEXTBOX_LEFT = 128;
	private void Button1_Click(object sender, System.EventArgs e)
	{
		int lastControl = (int)this.Session["LastControl"];
		int count = lastControl / 2 + 1;
		int top = TOP + HEIGHT * (count - 1);
		ControlInfo ci = PersistControl("Button" + count.ToString(),
			"Button",
			top, BUTTON_LEFT,
			"Click");
		Button btn = (Button)CreateControl(ci);
		btn.Text = "Button " + count.ToString();
		ci = PersistControl("TextBox" + count.ToString(),
			"TextBox",
			top, TEXTBOX_LEFT,
			"TextChanged");
		CreateControl(ci);
		this.Session["LastControl"] = count * 2;
	}
}
 