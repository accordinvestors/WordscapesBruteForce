# Wordscapes Brute Force - A fun project!!
Wordscapes Brute Force - (bot 🤖)

![GitHub Release](https://img.shields.io/github/v/release/TulkasLord/WordscapesBruteForce?include_prereleases&display_name=tag&label=Pre-Release)  
![GitHub Release](https://img.shields.io/github/v/release/TulkasLord/WordscapesBruteForce?display_name=tag&label=Release)

It's a fun project indeed! 
This project helps me tackle most games (like Wordscapes, WordConnect, WordCookies, etc...) with challenging words.

## In a nutshell ... 
**WordscapesBruteForce**, is just a simple .NET Core console App. written on C#. The App. searches through all the possible permutations from a given random letter and finds a 
*real* word from the dictionary (English for now!).

## The fun starts here with a simple question ...
- ``Question:`` *How do I resolve and distinguish "real" words from all those permutations?*
- ``Answer:`` **Look into a Merriam-Webster dictionary duh. I am a genius!!!** 😏

### e.g: 
The letters ``h``, ``o``, ``m`` and ``e`` (or ``home``) have 48 permutations 
with different lengths, let's say 3 as the minimum length per word.

``hom; hoe; hme; ome; home; hem; oem; hoem; hmo; moe; hmoe; heo; meo; hmeo; emo; 
hemo; eom; heom; ohm; ohe; ohme; ohem; omh; mhe; omhe; oeh; meh; omeh; emh; oemh; 
ehm; oehm; moh; mohe; moeh; mho; mhoe; mheo; eho; meho; eoh; meoh; eomh; eohm; emoh; 
emho; ehmo; ehom``

but only 2 are real word dictionaries!!

``home`` and ``hoe`` 😃

## The overall logic is nothing fancy ...
A little of the basics of Combinatorial knowledge, some MIT code (🥇) ... and voila! Start with permutations with variable size and send those permutations as requests to custom APIs, HTML, etc... to guarantee the existence of the real dictionary word and then save it in a local cache (JSON file) to avoid hitting too much Internet next time, acting as my first pool before doing any request. The word "home" is still a word in my hard drive locally or out there in the Library of Congress API (if any) 😄

Using multi-threaded parallel (TPL) techniques with batch processing techniques, and lazy loading, I guarantee that you can make thousands of simulated calls.

## Rights & Permissions about this code ... NONE!
This is free and **AS IS** you are responsible for helping yourself and doing what you think is best... make sure that it's better than the previous version  and share with others. 

### and ...
Don't worry I'm NOT going to ask for ☕ I learn how to code one! 😄

----------------------
YouTube: https://youtu.be/CV41DqRvyPw  (thanks son!)
