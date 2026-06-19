# Reverse a string without built-ins

**Tests**: Two-pointer technique, char arrays, basic string manipulation

Reverse a string in place (or build a reversed copy) without calling string.Reverse() or Array.Reverse(). Use a two-pointer swap approach.

**Starting signature**
```
public string ReverseString(string input)
```

**Constraints / Edge cases to handle**

- Empty string
- Single character
- String with spaces and punctuation

**Interviewer follow-ups (be ready)**

- Why is a string immutable in C#, and how does that affect your approach (hint: char[])?
- How would you reverse only the words in a sentence, but keep word order — e.g. 'Hello World' becomes 'olleH dlroW'?

**Target complexity:** O(n) time, O(n) space (since strings are immutable).

# Answers

- Why is a string immutable in C#, and how does that affect your approach (hint: char[])?
    - Becaue it's an array of chars and an array can't be resized. If I add a new char to the string a completly new array with the new size is needed.

- How would you reverse only the words in a sentence, but keep word order — e.g. 'Hello World' becomes 'olleH dlroW'?

    - By throwing the words into a list (spliting them with whitespaces), go through the list and reverse each one of them. Afterwards join the list into a string using whitespaces

- So here's the sharper question: is string in C# actually backed by a mutable char[] that the language just refuses to expose mutation methods for (a design choice), or is immutability a deeper guarantee than that — i.e., is there something about how string instances are used elsewhere (interning, being passed around as references, hashing, being used as dictionary keys) that would break if individual characters could be silently changed after the fact, even without resizing?

- Try answering: if strings were mutable (you could do someString[0] = 'X' and it just worked), and two variables held a reference to the same interned string "hello" (remember the interning exercise from the Hard sheet — same idea applies here), what would happen to the other variable when you mutated the first one? Why might that be a dangerous thing to allow by default?

    - Because it's a reference it could change the string at places where I don't want them to change and also comparing string a == string b would fail for example where it's relevant

- If strings were mutable and two variables pointed at the same interned "hello" instance — say a and b both reference it — and you mutated a[0] = 'H', would b also change, given they're the same object in memory? If yes, then a == b would still be true afterward (they're still equal, just now both say "Hello" instead of "hello") — so where does the actual danger show up?
Try this scenario instead: you put "hello" into a Dictionary<string, int> as a key. The dictionary computed a hash code for "hello" and stored it in a bucket based on that hash. Now, somewhere else in your program, a different variable that happens to reference that same string object mutates it to "world". What happens to the dictionary's internal bucket structure? Does the dictionary know the key changed? Can you still find that entry by looking up "hello", or "world", or neither?
That's the sharper version of the danger — it's not really about == failing, it's about any code anywhere in the program being able to silently corrupt a value that other, completely unrelated code is relying on staying constant, especially once that value's hash has already been computed and cached somewhere. Does that reframe make sense as the more precise "why"?

    - No as the hash would change / isn't the same

- So now if you call dict.ContainsKey("hello"), the dictionary computes hash("hello") fresh, looks in that bucket, and finds... nothing, because the actual key object now lives in the bucket for hash("world"), even though it's still sitting in the old bucket structurally. And dict.ContainsKey("world") would also fail, because the dictionary would compute the correct bucket for "world", but the entry isn't there either — it's still physically in the old bucket from when it was inserted as "hello". The dictionary entry becomes permanently unreachable. That's the real, concrete danger: not just "equality looks wrong," but data structures that depend on hash stability silently breaking in a way that's incredibly hard to debug, because nothing throws an exception — your data just quietly becomes unfindable