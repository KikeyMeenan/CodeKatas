import { FizzBuzz } from './FizzBuzz';

describe('fizzbuzz', () => {
    const tests: ((input: number) => string)[] = [
        (input: number) => { if (input % 3 === 0 && input % 5 === 0) return "fizzbuzz"; return ""; },
        (input: number) => { if (input % 3 === 0) return "fizz"; return ""; },
        (input: number) => { if (input % 5 === 0) return "buzz"; return ""; }
    ]

    const fizzBuzz = new FizzBuzz(tests);

    test('two is empty', () => {
        expect(fizzBuzz.Perform(2)).toBe("");
    });

    test('three is fizz', () => {
        expect(fizzBuzz.Perform(3)).toBe("fizz");
    });

    test('six is fizz', () => {
        expect(fizzBuzz.Perform(6)).toBe("fizz");
    });

    test('five is buzz', () => {
        expect(fizzBuzz.Perform(5)).toBe("buzz");
    });

    test('ten is buzz', () => {
        expect(fizzBuzz.Perform(10)).toBe("buzz");
    });

    test('fifteen is fizzbuzz', () => {
        expect(fizzBuzz.Perform(15)).toBe("fizzbuzz");
    });
})