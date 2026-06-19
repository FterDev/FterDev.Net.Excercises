# FizzBuzz, extended

**Tests**: Conditional logic, modulo operator, clean branching

Classic FizzBuzz: print numbers 1 to 100, but print 'Fizz' for multiples of 3, 'Buzz' for multiples of 5, and 'FizzBuzz' for multiples of both. Then generalize it to accept a Dictionary<int, string> of arbitrary divisor-to-word mappings.

**Starting Signature**

```
public static void FizzBuzz(int n)
public static string FizzBuzzGeneral(int number, Dictionary<int,string> rules)
```

**Constraints/Edgecases**

* Divisor of 0 in the rules dictionary (should not crash)
* Multiple rules matching the same number — what order should words appear in?

**Possible follow-ups**

* How would you make this work efficiently for n up to 10 million?
* Why might an interviewer ask this even though it seems 'too simple' — what are they actually checking?

**Target complexity**: O(n) time for the main loop.

# Answers

- How would you make this work efficiently for n up to 10 million?
    - The ruleset isn't the bottleneck but the list is. Because the modulo operations aren't stored or if then for a short period of time. But the list could become problematic because it's stored first and then after it's done it will generate the output. So it would take a waiting and RAM until it processes all callculations and afterwards puts them out. With yield return as solution you get a smooth output as it passes the already calculated result directly to the next method. with yield no storage of list is need so it's also better for resources and it's faster.

    `The rules loop isn't the bottleneck because its size is fixed and tiny (just the number of rules, R — typically 2 or 3), so it only adds a small constant multiplier to each iteration. It doesn't scale with n. The list, by contrast, does scale directly with n — at n=10 million it has to hold 10 million entries in memory before producing any output.
That's the sentence to use for the opening of your README answer. Now go fix the "faster" claim — same exercise as before, but this time I'll give you the precise wording too, since we've spent a while on this and it's reasonable to land it: yield doesn't change the time complexity (still O(n·R)) — it changes the memory profile (from O(n) storage down to O(1), since only one result exists at a time) and gives you the first result immediately instead of after a long upfront wait.`
- Why might an interviewer ask this even though it seems 'too simple' — what are they actually checking?

    - So it's about seeing how someone approaches the problem systematicaly and solves something basic. It's used as a low-bar entry to sort people out who can't even produce running code.

    `Now, the first half — the history — let's clear that up since you said it's confusing you. There's a well-known piece of programming folklore behind why FizzBuzz specifically became a famous interview screen, dating back to a blog post (by Jeff Atwood, I believe, early-2000s-ish) that pointed out something striking at the time: a surprisingly large number of people applying for programming jobs, with degrees and resumes, could not actually write working code for this when asked to do it live, on the spot, without a reference. Not "couldn't optimize it" — couldn't produce any correct solution at all, even a slow, naive one.
So the historical reason FizzBuzz exists as an interview question isn't really about you, specifically, at your level — it's a low-bar filter originally designed to catch candidates who could talk about programming in an interview but couldn't actually do it when asked to produce real, syntactically valid, logically correct code under modest pressure. For someone at your level, the question survives in interviews less as a real test and more as a quick warm-up / icebreaker — and the real signal an interviewer extracts from it shifts to exactly what you said: approach, clarity, structure, and whether you can talk through edge cases and complexity unprompted, since the "can you write a loop" bar is assumed to be trivially cleared.`