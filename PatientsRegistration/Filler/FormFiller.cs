using System;

namespace PatientsRegistration.Filler
{
    public static class FormFiller
    {
        public static void FillFormWithData(AddOrEditForm addOrEditForm, Record record) 
        {
            addOrEditForm.markCheckBox.Checked = record.Marked;
            addOrEditForm.typeComboBox.SelectedItem = record.Type;
            addOrEditForm.nameTextBox.Text = record.Name;
            addOrEditForm.departmentGroupComboBox.Text = record.DepartmentGroup;
            addOrEditForm.bedCountTextBox.Text = record.BedCount.ToString();
            addOrEditForm.consistedTextBox.Text = record.Consisted.ToString();
            addOrEditForm.receivedTextBox.Text = record.Received.ToString();
            addOrEditForm.ruralTextBox.Text = record.Rural.ToString();
            addOrEditForm.relocatedFromTextBox.Text = record.RelocatedFrom.ToString();
            addOrEditForm.relocatedToTextBox.Text = record.RelocatedTo.ToString();
            addOrEditForm.dischargedTextBox.Text = record.Discharged.ToString();
            addOrEditForm.diedTextBox.Text = record.Died.ToString();
            addOrEditForm.consistTextBox.Text = record.Consist.ToString();
            addOrEditForm.planKdnTextBox.Text = record.PlanKdn.ToString();
            addOrEditForm.factKdnTextBox.Text = record.FactKdn.ToString();
            addOrEditForm.ruralKdnTextBox.Text = record.RuralKdn.ToString();
        }

        public static void FillRecordWithData(Record record, AddOrEditForm addOrEditForm, int year, int month) 
        {
            record.Marked = addOrEditForm.markCheckBox.Checked;
            record.Type = addOrEditForm.typeComboBox.SelectedItem.ToString();
            record.Year = year;
            record.Month = month;
            record.Name = addOrEditForm.nameTextBox.Text;
            record.DepartmentGroup = addOrEditForm.departmentGroupComboBox.SelectedItem.ToString();
            record.BedCount = Convert.ToDouble(addOrEditForm.bedCountTextBox.Text);
            record.Consisted = Convert.ToDouble(addOrEditForm.consistedTextBox.Text);
            record.Received = Convert.ToDouble(addOrEditForm.receivedTextBox.Text);
            record.Rural = Convert.ToDouble(addOrEditForm.ruralTextBox.Text);
            record.RelocatedFrom = Convert.ToDouble(addOrEditForm.relocatedFromTextBox.Text);
            record.RelocatedTo = Convert.ToDouble(addOrEditForm.relocatedToTextBox.Text);
            record.Discharged = Convert.ToDouble(addOrEditForm.dischargedTextBox.Text);
            record.Died = Convert.ToDouble(addOrEditForm.diedTextBox.Text);
            record.Consist = Convert.ToDouble(addOrEditForm.consistTextBox.Text);
            record.PlanKdn = Convert.ToDouble(addOrEditForm.planKdnTextBox.Text);
            record.FactKdn = Convert.ToDouble(addOrEditForm.factKdnTextBox.Text);
            record.RuralKdn = Convert.ToDouble(addOrEditForm.ruralKdnTextBox.Text);
        }
    }
}
