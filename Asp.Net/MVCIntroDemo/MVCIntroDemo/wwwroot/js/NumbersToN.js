function NumbersToN() {
    let count = document.getElementById("countInput").value || 2;
    window.location = "https://localhost:7105/Home/NumbersToN?count="+count;
}