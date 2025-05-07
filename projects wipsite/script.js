function openMenu() {
    const nav = document.querySelector('nav');
    nav.classList.toggle('open');
}
//إنشاء رأي جديدة
function createCard() {
    const f_name = document.getElementById("first_name").value.trim();
    const l_name = document.getElementById("last_name").value.trim();
    const c_name = document.getElementById("country_name").value.trim();
    const text = document.getElementById("Text_message").value.trim();
  
    if (f_name === "" || l_name === "" || c_name === "" || text === "") {
      alert("تأكد من إدخال البيانات بشكل كامل");
      return;
    }
  
    const card = { f_name, l_name, c_name, text };
    const cards = JSON.parse(sessionStorage.getItem("cards")) || [];
    cards.push(card);
    sessionStorage.setItem("cards", JSON.stringify(cards));
    alert("تم إرسال رسالتك بنجاح!");
  }
  
  // عرض البطاقات عند تحميل صفحة "آراء الزوار"
  document.addEventListener("DOMContentLoaded", function () {
    if (document.title === "آراء الزوار") {
      const container = document.getElementById("other");
      const title_container=document.getElementById("other_title");
      const cards = JSON.parse(sessionStorage.getItem("cards")) || [];
  
      if (cards.length === 0) {
        container.style.display="none";
        return;
      }

      title_container.style.display="block";
      container.style.display="flex";
      cards.forEach(displayCard);
    }
  });
  
  // عرض بطاقة فردية
  function displayCard(card) {
    const container = document.getElementById("other");
    const cardDiv = document.createElement("div");
    cardDiv.className = "person4";
  
    // صورة + الاسم + الدولة
    const photoDiv = document.createElement("div");
    photoDiv.className = "photo-per4";
  
    const img = document.createElement("img");
    img.className = "photo4";
    img.src = "person-photos/person.jpg";
    img.alt = "personal-photo4";
    img.width = 40;
    img.height = 40;
  
    const name = document.createElement("h4");
    name.className = "name4";
    name.textContent = `${card.f_name} ${card.l_name}`;
  
    const country = document.createElement("h6");
    country.className="county";
    country.textContent = card.c_name;
  
    photoDiv.appendChild(img);
    photoDiv.appendChild(name);
    photoDiv.appendChild(country);
  
    // التعليق
    const comment = document.createElement("p");
    comment.className = "comment4";
    comment.innerHTML = card.text.replace(/\n/g, "<br>");
  
    // إضافة العناصر إلى البطاقة
    cardDiv.appendChild(photoDiv);
    cardDiv.appendChild(comment);
  
    container.appendChild(cardDiv);
  }
  