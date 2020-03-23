protected void btnLeeftijd_Click(object sender, EventArgs e)
        {
            Domain x = new Domain();
            string YesNo = x.AgeCheck(8);            
            lblGoedFout.Text = YesNo;     
        }
