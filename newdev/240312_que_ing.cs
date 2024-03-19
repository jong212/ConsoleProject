
//과제 : 배열을 이용해서 큐를 구현해라.
//1. 큐를 이용해서 로비시스템을 만든다
//2. 플레이어는 3명이 있다
//3. 플레이어는 로비에 입장을 하고
//4. 입장한 순서대로 전투를 진행한다
//ㄴEnqueue, Dequeue, IsFull, IsEmpty

using System;
using System.Collections;
using System.Collections.Generic;

class LobbySystem
{
    private Queue<string> players;

    public LobbySystem()
    {
        players = new Queue<string>();
    }

    public void EnterPlayer(string playerName)
    {
        players.Enqueue(playerName);
    }

    public void StartBattle()
    {
        while (players.Count > 0)
        {
            string player = players.Dequeue();
            Console.WriteLine(player + "님의 차례입니다. 전투를 시작합니다.");
            // 전투 진행하는 코드 작성
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        LobbySystem lobby = new LobbySystem();
        

        // 플레이어 입장
        lobby.EnterPlayer("플레이어1");
        lobby.EnterPlayer("플레이어2");
        lobby.EnterPlayer("플레이어3");

        // 전투 시작
        lobby.StartBattle();
    }
}
