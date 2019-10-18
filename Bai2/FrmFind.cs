using Bai2.Functions;
using System;
using System.Windows.Forms;

namespace Bai2
{
    public partial class FrmFind : Form
    {
        FrmNotePad frmNotePad = new FrmNotePad();
        FindNextResult nextResult = new FindNextResult();
        FindNextSearch nextSearch = new FindNextSearch();
        public FrmFind()
        {
            InitializeComponent();
            radDown.Checked = true;
            btnFindNext.Enabled = false;
            nextSearch.Success = false;
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
        }

        private void UpdateSearchQuery()
        {
            nextSearch.SearchString = txtFind.Text;
            nextSearch.Direction = radUp.Checked ? "UP" : "DOWN";
            nextSearch.MatchCase = chkMatchCase.Checked;
        }

        public FindNextResult FindNext(FindNextSearch search)
        {
            FindNextResult nextResult = new FindNextResult();
            int position;
            StringComparison stringComparison = search.MatchCase ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;
            if (search.Direction == "UP")
            {
                position = search.Content.Substring(0, search.Position).LastIndexOf(search.SearchString, stringComparison);
                search.Success = position >= 0 ? true : false;
                nextResult.SearchStatus = search.Success;
            }
            else
            {
                int start = search.Success ? search.Position + search.SearchString.Length : search.Position;
                position = start + search.Content.Substring(start, search.Content.Length - start).IndexOf(search.SearchString, stringComparison);
                search.Success = position >= 0 ? true : false;
                nextResult.SearchStatus = search.Success;
            }
            return nextResult;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            btnFindNext.Enabled = txtFind.Text.Length > 0 ? true : false;
            UpdateSearchQuery();
        }
    }
}
