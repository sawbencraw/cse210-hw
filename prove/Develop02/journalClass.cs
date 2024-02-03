class Journal {
    private List<Entry> entries;
    private string journalFolderPath;

    public Journal(string folderPath) {
        entries = new List<Entry>();
        journalFolderPath = folderPath;
    }

    public void AddEntry(Entry entry) {
        entries.Add(entry);
    }

    public void DisplayEntries() {
        foreach (Entry entry in entries) {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename) {
        try {
            string filePath = Path.Combine(journalFolderPath, filename);
            using (StreamWriter writer = new StreamWriter(filePath)) {
                foreach (Entry entry in entries) {
                    writer.WriteLine($"{entry.Date}: {entry.Prompt}");
                    writer.WriteLine(entry.Response + "\n");
                }
            }
            Console.WriteLine("Journal saved to file successfully.");
        } catch (Exception e) {
            Console.WriteLine($"Error saving journal to file: {e.Message}");
        }
    }

    public void LoadFromFile(string filename) {
        entries.Clear();
        try {
            string filePath = Path.Combine(journalFolderPath, filename);
            using (StreamReader reader = new StreamReader(filePath)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    DateTime date = DateTime.Parse(line.Substring(0, line.IndexOf(':')));
                    string prompt = line.Substring(line.IndexOf(':') + 2);
                    string response = reader.ReadLine();
                    entries.Add(new Entry(prompt, response, date));
                }
            }
            Console.WriteLine("Journal loaded from file successfully.");
        } catch (FileNotFoundException) {
            Console.WriteLine("File not found.");
        } catch (Exception e) {
            Console.WriteLine($"An error occurred while loading journal from file: {e.Message}");
        }
    }
}