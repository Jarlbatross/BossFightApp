// See https://aka.ms/new-console-template for more information
using BossFight;

var Hero = new GameCharacter("Hero", 100, 20, 40);
var Boss = new GameCharacter("Boss", 400, 0, 10);

var App = new App();

App.Play(Hero, Boss);