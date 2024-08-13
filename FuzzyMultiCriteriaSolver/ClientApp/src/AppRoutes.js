import DescribeObjective from "./components/DescribeObjectiveComponent/DescribeObjective";
import { Home } from "./components/Home";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
      path: '/describe-objective',
      element: <DescribeObjective />
  }
];

export default AppRoutes;
