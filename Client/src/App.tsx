import axios from "axios";
import { useEffect, useState } from "react";
import { List } from "semantic-ui-react";
import "./App.css";

function App() {
  const [posts, setPosts] = useState([]);

  useEffect(() => {
    axios.get("http://localhost:5000/Posts").then((response) => {
      setPosts(response.data);
    });
  });

  return (
    <>
      <List>
        {posts.map((post: any) => (
          <List.Item>{post.title}</List.Item>
        ))}
      </List>
    </>
  );
}

export default App;
