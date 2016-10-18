module Kata.TennisProperties

open Kata.Tennis

open FsCheck
open FsCheck.Xunit
open Swensen.Unquote

[<Property>]
let ``Given advantaged player when advantaged player wins score is correct``
  (player : Player) =
  let actual : Score = scoreWhenAdvantage player player

  let expected = Game player

  actual =! expected


[<Property>]
let ``Given advantaged player when the other player wins score is correct``
  (player : Player) =
  let actual : Score = scoreWhenAdvantage player (other player)

  Deuce =! actual

let ``Given Deuce, when player wins the score is correct``
  (player : Player) =
  let actual :Score = scoreWhenDeuce player

  let expected = Advantage player

  actual =! expected 

let ``Give game is over then it stays over`` (winner : Player) =
  let actual = scoreWhenGame winner
  let expected = Game winner

  expected =! actual