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
  if advantagedPlayer = winner then Game winner
  else Deuce

let other player = 
  match player with 
  | PlayerOne -> PlayerTwo
  | PlayerTwo -> PlayerOne

let scoreWhenDeuce = Advantage

let incrementPoint point =
  match point with
  | Love -> Some Fifteen
  | Fifteen -> Some Thirty
  | Thirty -> None


let pointTo player point current =
  match player with 
  | PlayerOne -> { current with PlayerOnePoint = point }
  | PlayerTwo -> { current with PlayerTwoPoint = point }

let pointForPlayer player current = 
  match player with 
  | PlayerOne -> current.PlayerOnePoint
  | PlayerTwo -> current.PlayerTwoPoint

let scoreWhenGame player =
  Game player