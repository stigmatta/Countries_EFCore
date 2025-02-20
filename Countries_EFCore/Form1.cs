using Microsoft.EntityFrameworkCore;
using Models;

namespace Countries_EFCore;
public partial class Form1 : Form
{

    SynchronizationContext sC;
    public Form1()
    {
        InitializeComponent();
        LoadContinents();
        LoadCountries();
        sC = SynchronizationContext.Current;
    }

    private void LoadContinents()
    {
        using (var db = new CountryDbContext())
        {
            var query = db.Continents.Select(x => x.Name).ToList();
            comboBox1.Items.AddRange(query.ToArray());
        }
    }

    private void LoadCountries()
    {
        using (var db = new CountryDbContext())
        {
            listBox1.Items.Clear();
            var countries = db.Countries.Select(x => x.Name).ToList();
            listBox1.Items.AddRange(countries.ToArray());
        }
    }

    private async void buttonAdd_Click(object sender, EventArgs e)
    {
        if (areBoxesEmpty())
        {
            MessageBox.Show("Some of the fields are empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        using (var db = new CountryDbContext())
        {
            var continent = db.Continents.FirstOrDefault(d => d.Name == comboBox1.Text);
            string name = textBoxName.Text;
            string capital = textBoxCapital.Text;
            int population = int.Parse(textBoxPopulation.Text);
            int square = int.Parse(textBoxSquare.Text);

            bool exists = await checkForRepeatAsync(name);
            if (exists)
            {
                MessageBox.Show("This country already exists in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await db.Countries.AddAsync(new Country
            {
                Continent = continent,
                Name = name,
                Capital = capital,
                Population = population,
                Square = square
            });

            await db.SaveChangesAsync();
            LoadCountries();

            sC.Send(_ => MessageBox.Show("Item has been added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information), null);

        }
    }

    bool areBoxesEmpty()
    {
        return (textBoxName.Text.Length == 0 || textBoxCapital.Text.Length == 0 || textBoxPopulation.Text.Length == 0 ||
            textBoxSquare.Text.Length == 0 || comboBox1.SelectedItem == null);
    }

    async Task<bool> checkForRepeatAsync(string name)
    {
        using (var db = new CountryDbContext())
        {
            bool exists = await db.Countries.AnyAsync(c => c.Name == name);
            return exists;
        }
    }



    private void textBoxPopulation_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            e.Handled = true;
    }

    private void textBoxSquare_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            e.Handled = true;
    }

    private async void buttonDelete_Click(object sender, EventArgs e)
    {
        if (listBox1.SelectedItem == null)
        {
            sC.Send(_ => MessageBox.Show("Select item to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error), null);
            return;
        }

        using (var db = new CountryDbContext())
        {
            var country = await db.Countries.FirstOrDefaultAsync(c => c.Name == listBox1.SelectedItem.ToString());
            if (country != null)
            {
                db.Countries.Remove(country);
                await db.SaveChangesAsync();
                LoadCountries();
            }

            sC.Send(_ => MessageBox.Show("Item has been deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information), null);
        }

    }

    private async void button1_Click(object sender, EventArgs e)
    {
        if (listBox1.SelectedItem == null)
        {
            MessageBox.Show("Choose an item to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (areBoxesEmpty())
        {
            MessageBox.Show("Some of the fields are empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        using (var db = new CountryDbContext())
        {
            var country = await db.Countries.FirstOrDefaultAsync(c => c.Name == listBox1.SelectedItem.ToString());
            if (country != null)
            {
                country.Continent = await db.Continents.FirstOrDefaultAsync(d => d.Name == comboBox1.Text);
                country.Name = textBoxName.Text;
                country.Capital = textBoxCapital.Text;
                country.Population = int.Parse(textBoxPopulation.Text);
                country.Square = int.Parse(textBoxSquare.Text);

                await db.SaveChangesAsync();

                LoadCountries();
            }

            sC.Send(_ => MessageBox.Show("Item has been edited", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information),null);
        }

    }


    private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        using (var db = new CountryDbContext()) {
            var country = await db.Countries.FirstOrDefaultAsync(d => d.Name == listBox1.SelectedItem.ToString());
            if(country != null)
            {
                comboBox1.SelectedItem = country.Continent.Name;
                textBoxName.Text = country.Name;
                textBoxPopulation.Text = country.Population.ToString();
                textBoxSquare.Text = country.Square.ToString();
                textBoxCapital.Text = country.Capital;
            }
        }
    }
}
