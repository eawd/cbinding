// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace CBinding {
    
    
    public partial class EditPackagesDialog {
        
        private Gtk.VPaned vpaned1;
        
        private Gtk.Notebook notebook1;
        
        private Gtk.ScrolledWindow scrolledwindow1;
        
        private Gtk.TreeView normalPackageTreeView;
        
        private Gtk.Label label1;
        
        private Gtk.ScrolledWindow scrolledwindow3;
        
        private Gtk.TreeView projectPackageTreeView;
        
        private Gtk.Label label2;
        
        private Gtk.Table table1;
        
        private Gtk.Label label3;
        
        private Gtk.ScrolledWindow scrolledwindow2;
        
        private Gtk.TreeView selectedPackagesTreeView;
        
        private Gtk.VBox vbox2;
        
        private Gtk.Button removeButton;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget CBinding.EditPackagesDialog
            this.Name = "CBinding.EditPackagesDialog";
            this.Title = Mono.Unix.Catalog.GetString("Edit packages");
            this.Modal = true;
            // Internal child CBinding.EditPackagesDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.vpaned1 = new Gtk.VPaned();
            this.vpaned1.CanFocus = true;
            this.vpaned1.Name = "vpaned1";
            this.vpaned1.Position = 183;
            this.vpaned1.BorderWidth = ((uint)(6));
            // Container child vpaned1.Gtk.Paned+PanedChild
            this.notebook1 = new Gtk.Notebook();
            this.notebook1.CanFocus = true;
            this.notebook1.Name = "notebook1";
            this.notebook1.CurrentPage = 0;
            // Container child notebook1.Gtk.Notebook+NotebookChild
            this.scrolledwindow1 = new Gtk.ScrolledWindow();
            this.scrolledwindow1.CanFocus = true;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            this.normalPackageTreeView = new Gtk.TreeView();
            this.normalPackageTreeView.CanFocus = true;
            this.normalPackageTreeView.Name = "normalPackageTreeView";
            this.normalPackageTreeView.HeadersClickable = true;
            this.scrolledwindow1.Add(this.normalPackageTreeView);
            this.notebook1.Add(this.scrolledwindow1);
            // Notebook tab
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("System Packages");
            this.notebook1.SetTabLabel(this.scrolledwindow1, this.label1);
            this.label1.ShowAll();
            // Container child notebook1.Gtk.Notebook+NotebookChild
            this.scrolledwindow3 = new Gtk.ScrolledWindow();
            this.scrolledwindow3.CanFocus = true;
            this.scrolledwindow3.Name = "scrolledwindow3";
            this.scrolledwindow3.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow3.Gtk.Container+ContainerChild
            this.projectPackageTreeView = new Gtk.TreeView();
            this.projectPackageTreeView.CanFocus = true;
            this.projectPackageTreeView.Name = "projectPackageTreeView";
            this.projectPackageTreeView.HeadersClickable = true;
            this.scrolledwindow3.Add(this.projectPackageTreeView);
            this.notebook1.Add(this.scrolledwindow3);
            Gtk.Notebook.NotebookChild w5 = ((Gtk.Notebook.NotebookChild)(this.notebook1[this.scrolledwindow3]));
            w5.Position = 1;
            // Notebook tab
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Project Packages");
            this.notebook1.SetTabLabel(this.scrolledwindow3, this.label2);
            this.label2.ShowAll();
            this.vpaned1.Add(this.notebook1);
            Gtk.Paned.PanedChild w6 = ((Gtk.Paned.PanedChild)(this.vpaned1[this.notebook1]));
            w6.Resize = false;
            // Container child vpaned1.Gtk.Paned+PanedChild
            this.table1 = new Gtk.Table(((uint)(2)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.Xalign = 0F;
            this.label3.Yalign = 0F;
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Selected packages:");
            this.table1.Add(this.label3);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.table1[this.label3]));
            w7.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.scrolledwindow2 = new Gtk.ScrolledWindow();
            this.scrolledwindow2.CanFocus = true;
            this.scrolledwindow2.Name = "scrolledwindow2";
            this.scrolledwindow2.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow2.Gtk.Container+ContainerChild
            this.selectedPackagesTreeView = new Gtk.TreeView();
            this.selectedPackagesTreeView.CanFocus = true;
            this.selectedPackagesTreeView.Name = "selectedPackagesTreeView";
            this.selectedPackagesTreeView.HeadersClickable = true;
            this.scrolledwindow2.Add(this.selectedPackagesTreeView);
            this.table1.Add(this.scrolledwindow2);
            Gtk.Table.TableChild w9 = ((Gtk.Table.TableChild)(this.table1[this.scrolledwindow2]));
            w9.TopAttach = ((uint)(1));
            w9.BottomAttach = ((uint)(2));
            w9.XOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.removeButton = new Gtk.Button();
            Gtk.Tooltips w10 = new Gtk.Tooltips();
            w10.SetTip(this.removeButton, "Remove selected package from the project.", "Remove selected package from the project.");
            this.removeButton.WidthRequest = 33;
            this.removeButton.HeightRequest = 33;
            this.removeButton.Sensitive = false;
            this.removeButton.CanFocus = true;
            this.removeButton.Name = "removeButton";
            this.removeButton.UseUnderline = true;
            // Container child removeButton.Gtk.Container+ContainerChild
            Gtk.Alignment w11 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w12 = new Gtk.HBox();
            w12.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w13 = new Gtk.Image();
            w13.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-remove", Gtk.IconSize.Menu, 16);
            w12.Add(w13);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w15 = new Gtk.Label();
            w15.LabelProp = "";
            w12.Add(w15);
            w11.Add(w12);
            this.removeButton.Add(w11);
            this.vbox2.Add(this.removeButton);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.vbox2[this.removeButton]));
            w19.Position = 0;
            w19.Expand = false;
            w19.Fill = false;
            this.table1.Add(this.vbox2);
            Gtk.Table.TableChild w20 = ((Gtk.Table.TableChild)(this.table1[this.vbox2]));
            w20.TopAttach = ((uint)(1));
            w20.BottomAttach = ((uint)(2));
            w20.LeftAttach = ((uint)(1));
            w20.RightAttach = ((uint)(2));
            w20.XOptions = ((Gtk.AttachOptions)(4));
            this.vpaned1.Add(this.table1);
            w1.Add(this.vpaned1);
            Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(w1[this.vpaned1]));
            w22.Position = 0;
            w22.Padding = ((uint)(3));
            // Internal child CBinding.EditPackagesDialog.ActionArea
            Gtk.HButtonBox w23 = this.ActionArea;
            w23.Name = "dialog1_ActionArea";
            w23.Spacing = 6;
            w23.BorderWidth = ((uint)(5));
            w23.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w24 = ((Gtk.ButtonBox.ButtonBoxChild)(w23[this.buttonCancel]));
            w24.Expand = false;
            w24.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w25 = ((Gtk.ButtonBox.ButtonBoxChild)(w23[this.buttonOk]));
            w25.Position = 1;
            w25.Expand = false;
            w25.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 580;
            this.DefaultHeight = 449;
            this.Show();
            this.removeButton.Clicked += new System.EventHandler(this.OnRemoveButtonClicked);
            this.removeButton.Clicked += new System.EventHandler(this.OnRemoveButtonClick);
            this.selectedPackagesTreeView.CursorChanged += new System.EventHandler(this.OnSelectedPackagesTreeViewCursorChanged);
            this.buttonCancel.Clicked += new System.EventHandler(this.OnCancelButtonClick);
            this.buttonOk.Clicked += new System.EventHandler(this.OnOkButtonClick);
        }
    }
}