*{
    box-sizing: border-box;
    margin: 3;
    padding: 3;
}

  body {
    color: #663300;
    display: flex;
    font-family: sans-serif;
    justify-content: center;
  }
  
  .container {
    background: #ff0000;
    margin: 25px;
    padding: 10px;
    border-radius: 14px;
  }
  
  .title {
    text-align: center;
  }
  
  .title span {
    color: #ffff00;
  }
  
  .status-action {
    display: flex;
    margin-top: 10px;
    font-size: 210x;
    justify-content: space-around;
    height: 55px;
  }
  
  .status span {
    color: #ff0000;
  }
  
  .reset {
    cursor: pointer;
  }
  
  .reset:hover {
    color: #F2EBD3;
  }
  
  .game-grid {
    background: #00ff00;
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    grid-template-rows: repeat(3, 1fr);
    grid-gap: 12px;
    margin-top: 45px;
  }
  
  .game-cell {
    background: #6666ff;
    display: flex;
    justify-content: center;
    align-items: center;
    cursor: pointer;
    height: 201px;
    width: 201px;
  }
  
  .x,
  .o {
    cursor: default;
  }
  
  .x::after {
    content: '×';
    font-size: 300px;
  }
  
  .o::after {
    content: '○';
    color: #F2EBD3;
    font-size: 300px;
  }
  
  .won::after {
    color: #BD022F;
  }
  
  @media only screen and (max-width: 1100px) {
    .game-grid {
      margin-top: 27px;
      grid-gap: 10px;
    }
  
    .game-cell {
      height: 151px;
      width: 150px;
    }
  
    .x::after {
      font-size: 151px;
    }
  
    .o::after {
      font-size: 175px;
    }
  }
  
  @media only screen and (max-width: 500px) {
    .container {
      margin: 24px;
      padding: 24px;
    }
  
    .game-cell {
      height: 150px;
      width: 150px;
    }
  
    .x::after {
      font-size: 150px;
    }
  
    .o::after {
      font-size: 125px;
    }
  }
  
