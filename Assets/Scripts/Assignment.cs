using UnityEngine;

public class Assignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         As01_CheckNumberSign();
         As02_GetDayName();
         As03_ValidatePassword();
         As04_GetGrade();
         As05_IsLeapYear();
         As06_Calculate();
         As07_GetSeason();
         As08_PurchasingSystemExample();
         As09_RockPaperScissorsExample();
         As10_CalculateWeaponDamage();
         As11_DeterminePlayerRank();
    }

    public int as01Number;
    public void As01_CheckNumberSign()
    {
        // TODO: Implement logic to determine sign
        // Example: Debug.Log("Positive");
         Debug.Log("AS01: Input : " + as01Number );
        // If check
        if (as01Number > 0)
        {
            Debug.Log("Positive");
        }
        else if (as01Number < 0)
        {
            Debug.Log("Negative");
        }
        else
        {
            Debug.Log("Zero");   
        }
    }

    public int as02Day;
    public void As02_GetDayName()
    {
        // TODO: Implement logic to return day name
        // Example: Debug.Log("Monday");
        Debug.Log("AS02: Input : " + as02Day );
        switch (as02Day)
        {
            case 1: Debug.Log("Monday"); break;

            case 2: Debug.Log("Tuesday"); break;

            case 3: Debug.Log("Wednesday"); break;

            case 4: Debug.Log("Thursday"); break;

            case 5: Debug.Log("Friday"); break;

            case 6: Debug.Log("Saturday"); break;

            case 7: Debug.Log("Sunday"); break;

            case 8: Debug.Log("Invalid day"); break;
        }
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        // TODO: Implement password validation logic
        // Example: Debug.Log("True");
         Debug.Log("AS03: Input Password : " + as03InputPassword );
        Debug.Log("AS03: Input CorrectPassword : " + as03CorrectPassword );
        Debug.Log(as03InputPassword == as03CorrectPassword ? "True" : "False");
    }

    public int as04Score;
    public void As04_GetGrade()
    {
        Debug.Log("AS04: Input Score: " + as04Score );
        if (as04Score >= 80)
        {
            Debug.Log("A");
        }
        else if (as04Score >= 70)
        {
            Debug.Log("B");
        }
        else if (as04Score >= 60)
        {
            Debug.Log("C"); 
        }
        else if (as04Score >= 50)
        {
            Debug.Log("D"); 
        }
        else
        {
            Debug.Log("F");
        }
    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        // TODO: Implement leap year check logic
        // Example: Debug.Log("True");
        Debug.Log("AS05: Input Year: " + as05Year );
        if (as05Year % 400 == 0)
        {
            Debug.Log("True");
        }
        else if (as05Year % 100 == 0)
        {
            Debug.Log("False");
            
        }
        else if (as05Year % 4 == 0)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False"); 
        }
    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public void As06_Calculate()
    {
        // TODO: Implement calculator logic
        // Example: Debug.Log("Result: 42");
         Debug.Log("AS06: Input Num1: " + as06Num1 );
        Debug.Log("AS06: Input Op: " + as06Op );
        Debug.Log("AS06: Input Num2: " + as06Num2 );

        double result = 0; 
        bool isValid = true;
        switch (as06Op)
        {
            case '+' : result = as06Num1 + as06Num2; break;
            case '-' : result =  as06Num1 - as06Num2; break;
            case '*' : result = as06Num1 * as06Num2; break;
            case '/' :
                if (as06Num2 == 0)
                {
                    Debug.Log("Error: Cannot divide by zero.");
                    isValid = false;
                }
                else
                {
                    result = as06Num1 / as06Num2;
                }
                break;
            default:
                Debug.Log("Invalid operator. Please use +, -, *, or /.");
                isValid = false;
                break;
        }

        if (isValid)
        {
            Debug.Log("Result: " + result);
        }
    }

    public int as07Month;
    public void As07_GetSeason()
    {
        // TODO: Implement logic to return season
        // Example: Debug.Log("Summer");
        Debug.Log("AS07: Input Month: " + as07Month );
        if (as07Month >= 1 && as07Month <= 12)
        {
            if (as07Month == 12 || as07Month == 1 || as07Month == 2)
            {
                Debug.Log("It's Winter.");
            }
            else if (as07Month == 3 || as07Month == 4 || as07Month == 5)
            {
                Debug.Log("It's Spring.");
            }
            else if (as07Month == 6 || as07Month == 7 || as07Month == 8)
            {
                Debug.Log("It's Summer.");
            }
            else if (as07Month == 9 || as07Month == 10 || as07Month == 11)
            {
                Debug.Log("It's Fall.");
            }
            else
            {
                Debug.Log("Invalid month number. Please enter a number between 1 and 12.");
            }
        }
    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        Debug.Log("AS08: Input Quantity: " + as08Quantity );
        Debug.Log("AS08: Input Price: " + as08Price );
        Debug.Log("AS08: Input Payment: " + as08Payment );
        if (as08Quantity > 0)
        {
            if (as08Payment > as08Price)
            {
                as08Quantity -= as08Quantity;
                Debug.Log("คุณได้รับสินค้าแล้ว");
                as08Payment -= as08Price;
                Debug.Log("คุณได้รับเงินทอน " + as08Payment + " บาท");
            }
            else if (as08Payment == as08Price)
            {
                as08Quantity -= as08Quantity;
                as08Payment -= as08Price;
                Debug.Log("คุณได้รับสินค้าแล้ว");
            }
            else
            {
                Debug.Log("คุณมีเงินไม่เพียงพอ");
            }
        }
        else
        {
            Debug.Log("สินค้าหมด");
        }
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        Debug.Log("0 = Rock , 1 = Paper , 2 = Scissors");
        Debug.Log("AS09: Input Choice: " + as09UserChoice );
        Debug.Log("AS09: ComputerChoice: " + as09ComputerChoice );
        if (as09UserChoice == 0 || as09UserChoice == 1 || as09UserChoice == 2)
        {
            if (as09UserChoice == as09ComputerChoice)
            {
                Debug.Log("Draw");
            }
            else if ((as09UserChoice == 0 && as09ComputerChoice == 2) || (as09UserChoice == 1 && as09ComputerChoice == 0) || (as09UserChoice == 2 && as09ComputerChoice == 1))
            {
                Debug.Log("Win");
            }
            else
            {
                Debug.Log("Lose");
            }
        }
        else
        {
            Debug.Log("กรุณาเลือกเป็นตัวเลขที่ถูกต้อง");
        }
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
         Debug.Log("AS10: Input Weapon Type: " + as10WeaponType );
        Debug.Log("AS10: Input Base dmg: " + as10BaseDamage );
        double multiplier = 1.0;
        switch (as10WeaponType?.ToLower())
        {
            case "sword": multiplier = 1.3; break;
            case "axe": multiplier = 1.4; break;
            case "bow": multiplier = 1.2; break;
            case "staff": multiplier = 1.5; break;
            case "dagger": multiplier = 1.1; break;
            default: multiplier = 1.0;  break;
        }
        int totalDamage = (int)(as10BaseDamage * multiplier);
        Debug.Log(totalDamage.ToString());
    }

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        Debug.Log("AS11: Input Score: " + as11Score );
        Debug.Log("AS11: Input CompletionTime: " + as11CompletionTime );
        if (as11Score < 0 || as11CompletionTime < 0)
        {
            Debug.Log("Invalid score or time");
            return;
        }

        string playerRank;
        int baseCoins;
        if (as11Score >= 8000)
        {
            playerRank = "Gold";
            baseCoins = 100;
        }
        else if (as11Score >= 6000)
        {
            playerRank = "Silver";
            baseCoins = 75;
        }
        else if (as11Score >= 4000)
        {
            playerRank = "Bronze";
            baseCoins = 50;
        }
        else
        {
            playerRank = "Participation";
            baseCoins = 25;
        }
        
        int timeBonus = 0;
        if (as11CompletionTime <= 30)
        {
            timeBonus = 25;
        }
        else if (as11CompletionTime <= 60)
        {
            timeBonus = 10;
        }

        int totalCoins = baseCoins + timeBonus;
        Debug.Log($"{playerRank} Rank - {totalCoins} coins earned!");
    }
}
