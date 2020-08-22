export class FizzBuzz {
    Rules: FizzBuzzRule[]

    constructor(rules: FizzBuzzRule[]) {
        this.Rules = rules
    }
 
    Perform(input: number): string {
        let divisibleByAll = this.CheckDivisibleByAllNumbers(input, this.Rules.map(x=>x.Number));

        if(divisibleByAll) return this.Rules.map(x=>x.Output).join().replace(",", "");

        for (let rule of this.Rules) {
            let isDivisible = this.CheckDivisibleByAllNumbers(input, [rule.Number]);
            if (isDivisible) return rule.Output;
        }

        return "";
    }

    CheckDivisibleByAllNumbers(input: number, ruleNumbers: number[]) {
        let divisibleByAll = true;
        let currentNumber = 0;
        
        while (currentNumber <= ruleNumbers.length - 1 && divisibleByAll == true) {
            divisibleByAll = this.CheckDivisible(input, ruleNumbers[currentNumber]);
            currentNumber++;
        }
        return divisibleByAll;
    }

    CheckDivisible(left: number, right: number): boolean {
        if (left % right === 0) {
            return true;
        }
    }
}

export class FizzBuzzRule {
    Number: number
    Output: string
}