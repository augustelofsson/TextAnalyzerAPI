function GetAnalyzedWords() {
  var inputVal = document.getElementById("input").value;
  var resultsDiv = document.getElementById("response");
  resultsDiv.innerHTML = '';
  fetch(`https://5db3-83-172-102-36.ngrok.io/api/Analyze?text=${inputVal}`)
    .then((response) => {
      if (!response.ok) {
        throw Error("Error");
      }
      return response.json();
    })

    .then((data) => {
      const wordHtml = data.analyzedWords.map((word) => {
        return (resultsDiv.innerHTML += `
          <div class="word">
              <h3>${word.name}: ${word.count}</h3>
          </div>
          `);
      });
    })
    .catch((error) => {
      console.log(error);
    });
}

var button = document.getElementById("button");

button.onclick = function () {
  GetAnalyzedWords();
};
