const resultContainer = document.getElementById("resultContainer");
const resultOutput = document.getElementById("result");

function updateResult(json) {
  resultOutput.textContent = JSON.stringify(json, null, 2);
}

async function fetchData(url, method, data = null) {
  const options = {
    method,
    headers: {
      Accept: "application/json",
      "Content-Type": "application/json",
    },
    body: data,
  };

  const response = await fetch(url, options);
  return await response.json();
}

async function handleGetAll() {
  const users = await fetchData("/api/users", "GET");
  updateResult(users);
}

async function handleGet() {
  const userId = document.getElementById("userIdAdd").value;
  const user = await fetchData(`/api/users/${userId}`, "GET");
  updateResult(user);
}

async function handleCreate() {
  const data = document.getElementById("createUserData").value;
  const newUser = await fetchData("/api/users", "POST", data);
  updateResult(newUser);
}

async function handleUpdate() {
  const data = document.getElementById("updateUserData").value;
  const userId = document.getElementById("userIdUpdate").value;
  const updatedUser = await fetchData(`/api/users/${userId}`, "PUT", data);
  updateResult(updatedUser);
}

async function handleDelete() {
  const userId = document.getElementById("userIdDelete").value;
  const deletedUser = await fetchData(`/api/users/${userId}`, "DELETE");
  updateResult(deletedUser);
}

document.getElementById("getAll").addEventListener("click", handleGetAll);
document.getElementById("get").addEventListener("click", handleGet);
document.getElementById("create").addEventListener("click", handleCreate);
document.getElementById("update").addEventListener("click", handleUpdate);
document.getElementById("delete").addEventListener("click", handleDelete);