// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace AVCustomEdit
{
	public partial class TransitionTypeController : UITableViewController
	{
		public Action<int> TransitionTypePicked;

		public const int DiagonalWipeTransition = 0;
		public const int CrossDissolveTransition = 1;

		public UITableViewCell CrossDissolveCell {
			get {
				return crossDissolveCell;
			}
			set {
				crossDissolveCell = value;
			}
		}

		public UITableViewCell DiagonalWipeCell {
			get {
				return diagonalWipeCell;
			}
			set {
				diagonalWipeCell = value;
			}
		}

		public int CurrentTransition;

		public TransitionTypeController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.tableView.Delegate = new TableViewDelegate ();
		}

		partial void TransitionSelected (Foundation.NSObject sender)
		{
			TransitionTypePicked (CurrentTransition);
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell selectedCell = tableView.CellAt (indexPath);
			selectedCell.EditingAccessory = UITableViewCellAccessory.Checkmark;

			switch (selectedCell.Tag) {
			case TransitionTypeController.DiagonalWipeTransition:
				CrossDissolveCell.Accessory = UITableViewCellAccessory.None;
				if (TransitionTypePicked != null)
					TransitionTypePicked (TransitionTypeController.DiagonalWipeTransition);
				CurrentTransition = DiagonalWipeTransition;
				break;
			case TransitionTypeController.CrossDissolveTransition:
				DiagonalWipeCell.Accessory = UITableViewCellAccessory.None;
				if (TransitionTypePicked != null)
					TransitionTypePicked (TransitionTypeController.CrossDissolveTransition);
				CurrentTransition = CrossDissolveTransition;
				break;
			default:
				break;
		}

			tableView.DeselectRow (indexPath, true);
		}
	}

	public class TableViewDelegate : UITableViewDelegate
	{
		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{

		}
	}
}
