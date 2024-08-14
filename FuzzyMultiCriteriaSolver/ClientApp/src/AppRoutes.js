import DescribeObjective from "./components/DescribeObjectiveComponent/DescribeObjective";
import { Home } from "./components/Home";
import ObjectivesList from "./components/ObjectivesListComponent/ObjectivesList";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
      path: '/describe-objective',
      element: <DescribeObjective />
  },
  {
      path: '/objectives',
      element: <ObjectivesList />
  }
];

export default AppRoutes;
