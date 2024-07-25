<h1>FIZZ BUZZ KATA</h1>

![How-TDD-Works](https://github.com/user-attachments/assets/861e350c-66b3-450e-a4ad-da85f0a707dd)


<h2>Problem Description</h2>
<p>
  Imagine the scene. You are eleven years old, and in the five minutes before the end of the lesson, your Maths teacher decides he should make his class more “fun” by introducing a “game”. 
  He explains that he is going to point at each pupil in turn and ask them to say the next number in sequence, starting from one. The “fun” part is that if the number is divisible by three, 
  you instead say “Fizz” and if it is divisible by five you say “Buzz”. So now your maths teacher is pointing at all of your classmates in turn, and they happily shout “one!”, “two!”, “Fizz!”, “four!”, “Buzz!”… until 
  he very deliberately points at you, fixing you with a steely gaze… time stands still, your mouth dries up, your palms become sweatier and sweatier until you finally manage to croak “Fizz!”. 
  Doom is avoided, and the pointing finger moves on. <br /><br />
  So of course in order to avoid embarassment infront of your whole class, you have to get the full list printed out so you know what to say. <br /><br />
  Your class has about 33 pupils and he might go round three times before the bell rings for breaktime. Next maths lesson is on Thursday. Get coding!
</p>

<h3>STAGE 1</h3>
<p>Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. 
  For numbers which are multiples of both three and five print “FizzBuzz “.</p>

  <p>SAMPLE OUTPUT</p>
  
<img width="254" alt="Screenshot 2024-07-25 at 11 08 23" src="https://github.com/user-attachments/assets/336de608-106e-42f5-b774-80217ed41438">

<h3>STAGE 2</h3>
<p>
<ul>
  <li>A number is fizz if it is divisible by 3 or if it has a 3 in it</li>
  <li>A number is buzz if it is divisible by 5 or if it has a 5 in it</li>
</ul>

<p>For exemple :</p>
<ul>
  <li>53 should return FizzBuzz (contain 5 and 3)</li>
  <li>35 should return FizzBuzz (contain 3 and 5 and it divided by 5)
</li>
</ul>
</p>

<h3>STAGE 3</h3>
<p>
  <ul>
    <li>A number is Whizz if the sum of it's digits is equal to 7</li>
  </ul>

  <p>For exemple :</p>
<ul>
  <li>52 should return BuzzWhizz (contain 5 and sums 7)</li>
</li>
</ul>
</p>
  
