import { Header } from "../../components/Header";
import ItemList from "../../components/ItemList";
import background from "../../assets/background.png";
import "./styles.css";

function App() {
  return (
    <div className="App">
      <Header />
      <div className="content">
        <img src={background} className="background" alt="background" />
        <div className="info">
          <div>
            <input type="user" placeholder="@username" />
            <button>Search</button>
          </div>
          <div className="profile">
            <img src="https://avatars.githubusercontent.com/u/112426855?v=4" className="profile-image" alt="" />
            <div>
              <h3>Renan Garcia</h3>
              <span>@renanrgarcia</span>
              <p>Description</p>
            </div>
          </div>
          <hr/>
          <div>
            <h4 className="repository">Repositories</h4>
            <ItemList title="Repository 1" description="Description" />
            <ItemList title="Repository 2" description="Description" />
            <ItemList title="Repository 3" description="Description" />
          </div>
        </div>
      </div>
    </div>
  );
}

export default App;