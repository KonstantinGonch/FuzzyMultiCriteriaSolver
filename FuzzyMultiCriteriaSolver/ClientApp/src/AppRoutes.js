import DescribeObjective from "./components/DescribeObjectiveComponent/DescribeObjective";
import DescribeVariables from "./components/DescribeVariablesComponent/DescribeVariables";
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
    },
    {
      path: '/describe-variables',
      element: <DescribeVariables />
	}
];

export default AppRoutes;
