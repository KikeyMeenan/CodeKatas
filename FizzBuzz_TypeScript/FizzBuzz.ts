export class FizzBuzz {
    Rules: ((input: number) => string)[]

    constructor(rules: ((input: number) => string)[]) {
        this.Rules = rules
    }

    Perform(input: number) : string {
        for(let rule of this.Rules){
            var result = rule(input);
            if(result != ""){
                return result;
            }
        }
        return "";
    }
}