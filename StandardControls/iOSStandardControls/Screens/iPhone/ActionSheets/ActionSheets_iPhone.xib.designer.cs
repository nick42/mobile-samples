// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_StandardControls.Screens.iPhone.ActionSheets {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("ActionSheets_iPhone")]
	public partial class ActionSheets_iPhone {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UIButton __mt_btnSimpleActionSheet;
		
		private MonoTouch.UIKit.UIButton __mt_btnActionSheetWithOtherButtons;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("btnSimpleActionSheet")]
		private MonoTouch.UIKit.UIButton btnSimpleActionSheet {
			get {
				this.__mt_btnSimpleActionSheet = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("btnSimpleActionSheet")));
				return this.__mt_btnSimpleActionSheet;
			}
			set {
				this.__mt_btnSimpleActionSheet = value;
				this.SetNativeField("btnSimpleActionSheet", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("btnActionSheetWithOtherButtons")]
		private MonoTouch.UIKit.UIButton btnActionSheetWithOtherButtons {
			get {
				this.__mt_btnActionSheetWithOtherButtons = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("btnActionSheetWithOtherButtons")));
				return this.__mt_btnActionSheetWithOtherButtons;
			}
			set {
				this.__mt_btnActionSheetWithOtherButtons = value;
				this.SetNativeField("btnActionSheetWithOtherButtons", value);
			}
		}
	}
}
