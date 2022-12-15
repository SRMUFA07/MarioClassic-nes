const Web3 = require('web3');
const web3 = new Web3(window.ethereum);

mergeInto(LibraryManager.library, {
    Accrue:function(score,token,seconds){
        const walletAddress = web3.eth.accounts[0]
        const request = new XMLHttpRequest()
        request.open("GET",`https://segagame.club/api/game/accrue?score=${score}&token=${token}&seconds=${seconds}&walletAddress=${walletAddress}`)
        request.send()
    }
});