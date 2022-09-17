using NonLinearDataStructure;

MyMapNode<string, int> hash = new MyMapNode<string, int>(19);
string words = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
string[] arr = words.Split(' ');
LinkedList<string> checkForDuplication = new LinkedList<string>();
foreach (string element in arr)
{
    int count = 0;
    foreach (string match in arr)
    {
        if (element == match)
        {
            count++;
            if (checkForDuplication.Contains(element))
            {
                break;
            }
        }
    }
    if (checkForDuplication.Contains(element))
    {
        continue;
    }
    checkForDuplication.AddLast(element);
    hash.Add(element, count);
}
Console.WriteLine("Frequency Of The Words");
hash.Display();

//UC-3
int freq = hash.Get("avoidable");
Console.WriteLine("Frequency of The Word avoidable: " + freq);
hash.Remove("avoidable");
freq = hash.Get("avoidable");
Console.WriteLine("Frequency of The Word avoidable After Removing: " + freq);
hash.Display();