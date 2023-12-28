namespace Passwords;

public class CaseAlternatorTask
{
	//Тесты будут вызывать этот метод
	public static List<string> AlternateCharCases(string lowercaseWord)
	{
		var result = new List<string>();
		AlternateCharCases(lowercaseWord.ToCharArray(), 0, result);
		return result;
	}

	static void AlternateCharCases(char[] word, int index, List<string> result)
	{
		if (index == word.Length)
		{
			result.Add(new string(word));
			return;
		}

		var ch = word[index];
		var upperCh = char.ToUpper(ch);
		var lowerCh = char.ToLower(ch);
			
		if (char.IsLetter(ch) && upperCh != lowerCh)
		{
			word[index] = lowerCh;
			AlternateCharCases(word, index + 1, result);
			word[index] = upperCh;
			AlternateCharCases(word, index + 1, result);
		}
		else
			AlternateCharCases(word, index + 1, result);
	}
}