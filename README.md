# ConsoleApp1 – Cybersecurity Awareness Bot

## Overview

ConsoleApp1 is a C# console application designed to educate users about cybersecurity while providing an interactive chatbot experience. The program includes audio, user input validation, emotional interaction, and a simple response system.

---

## Features

### Audio Greeting

* Plays a voice message when the program starts
* Uses `SoundPlayer` to play **WelcomeMessage.wav**
* Includes error handling if the file cannot be played

---

### ASCII Display

* Displays a styled welcome banner
* Uses green text for visual enhancement

---

### Loading Animation

* Simulates a progress bar
* Uses a loop and `Thread.Sleep()` to show loading from 0% to 100%

---

### User Input

* Prompts user to enter their name
* Validates that:

  * Input is not empty
  * Input does not contain numbers
* Displays a personalized welcome message

---

### Emotion Handling

* Asks the user how they are feeling
* Requires a response before continuing
* Detects keywords such as:

  * happy, sad, tired, angry, stressed
* Responds with supportive messages
* Displays suggested chatbot questions

---

### Chatbot System

* Runs in a continuous loop until user exits
* Commands:

  * `help` → shows available questions
  * `exit` → ends the program

#### Supported Topics:

* Cybersecurity basics
* Phishing emails
* Suspicious links
* Reporting threats

---

### Bot Emotions

* The bot can respond with its own “feelings”
* Uses dictionaries to store:

  * Emotions (happy, sad, curious, tired)
  * Multiple reasons for each emotion
* Ensures responses are random and not repeated immediately

---

### Play Class

* Alternative way to play audio
* Uses constructor to trigger sound playback
* Uses `PlaySync()` to wait until audio finishes
* Includes exception handling

---

## Program Flow

1. Display ASCII banner
2. Play greeting audio
3. Show loading animation
4. Ask for user name
5. Ask user’s feeling
6. Start chatbot interaction

---

## Technologies Used

* C#
* .NET Console Application
* System Libraries:

  * `System.Media`
  * `System.Threading`
  * `System.Collections.Generic`

---

## Limitations

* Uses keyword matching instead of AI
* Limited cybersecurity topics
* Audio file must exist in project folder
* Duplicate audio functionality

---

## Conclusion

ConsoleApp1 demonstrates the use of object-oriented programming, user input validation, and a basic chatbot system. It provides a strong foundation for building more advanced cybersecurity awareness applications.

---
