module Kata.Tennis

type Player = 
  | PlayerOne
  | PlayerTwo

type Point =
  | Love
  | Fifteen
  | Thirty

type PointsData = {
  PlayerOnePoint : Point
  PlayerTwoPoint : Point
}

type FortyData = {
  Player : Player
  OtherPlayerPoint : Point
}

type Score = 
  | Points of PointsData
  | Forty of FortyData
  | Deuce
  | Advantage of Player
  | Game of Player

let scoreWhenAdvantage advantagedPlayer winner =
  Deuce