export class FizzBuzz {
    Tests: ((input: number) => string)[];

    constructor(tests: ((input: number) => string)[]) {
        this.Tests = tests;
    }

    Perform(input: number): string {
        for (let test of this.Tests) {
            let testResult = test(input);
            if (testResult != "") return testResult;
        }
        return "";
    }
}