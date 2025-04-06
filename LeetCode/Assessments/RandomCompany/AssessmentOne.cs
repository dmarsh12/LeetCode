namespace LeetCode.Assessments.RandomCompany;

public class AssessmentOne
{
    public static string AddStrings(string num1, string num2)
    {
        int i = num1.Length - 1;
        int j = num2.Length - 1;
        int carry = 0;
        var result = new System.Text.StringBuilder();

        // Loop until both strings are processed, or there's a carry left
        while (i >= 0 || j >= 0 || carry != 0)
        {
            int sum = carry;
            
            // Add the current digit from num1 if available
            if (i >= 0)
            {
                sum += num1[i] - '0'; // Convert char to int
                i--;
            }

            // Add the current digit from num2 if available
            if (j >= 0)
            {
                sum += num2[j] - '0'; // Convert char to int
                j--;
            }

            // Append the result of the current digit
            result.Insert(0, sum % 10); // We are adding digits to the front

            // Calculate the carry for the next digit
            carry = sum / 10;
        }

        // Return the result as a string
        return result.ToString();
    }
    
    public static bool IsPalindrome(int x)
    {
        var numberAsString = x.ToString();
        var length = numberAsString.Length-1;

        if (length is 0)
            return true;
        
        var i = 0; 
        var j = length;
        
        while (i < j)
        {
            if (numberAsString[i] != numberAsString[j])
                return false;
            
            i++;
            j--;
        }

        return true;
    }
}