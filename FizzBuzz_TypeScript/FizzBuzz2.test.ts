import { FizzBuzz, FizzBuzzRule } from './FizzBuzz2';

describe('fizzbuzz 2', () => {
    const rules: FizzBuzzRule[] = [
        {Number: 3, Output: "fizz"},
        {Number: 5, Output: "buzz"}
    ]

    const fizzBuzz = new FizzBuzz(rules);

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